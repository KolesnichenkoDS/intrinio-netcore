using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace Intrinio.RealTime
{
    internal class IexMessage
    {
        public string Event { get; }
        public IexQuote Payload { get; }

        public IexMessage(string Event, IexQuote Payload)
        {
            this.Event = Event;
            this.Payload = Payload;
        }
    }

    internal class CryptoquoteMessage
    {
        public string Event { get; }
        public JObject Payload { get; }

        public CryptoquoteMessage(string Event, JObject Payload)
        {
            this.Event = Event;
            this.Payload = Payload;
        }
    }

    internal class FxcmMessage
    {
        public string Event { get; }
        public JObject Payload { get; }

        public FxcmMessage(string Event, JObject Payload)
        {
            this.Event = Event;
            this.Payload = Payload;
        }
    }

    internal class QuoddMessage
    {
        public string Event { get; }
        public JObject Data { get; }

        public QuoddMessage(string Event, JObject Data)
        {
            this.Event = Event;
            this.Data = Data;
        }
    }

    internal class QuoddInfoData
    {
        public string Action { get; }
        public string Message { get; }

        public QuoddInfoData(string Action, string Message)
        {
            this.Action = Action;
            this.Message = Message;
        }
    }

    /// <summary>
    ///     The available providers/vendors of real-time price quotes. Each provider requires a subscription from
    ///     https://intrinio.com
    /// </summary>
    public enum QuoteProvider
    {
        /// <summary>
        ///     The Investor's Exchange https://iextrading.com/
        /// </summary>
        IEX,

        /// <summary>
        ///     QUODD http://home.quodd.com/
        /// </summary>
        QUODD,

        /// <summary> Cryptoquote https://cryptoquote.io </summary>
        CRYPTOQUOTE,

        /// <summary> FXCM https://www.fxcm.com/ </summary>
        FXCM
    }

    /// <summary>
    ///     Intrinio's client for receiving real-time stock prices via a WebSocket connection.
    /// </summary>
    public class RealTimeClient : IDisposable
    {
        /// <summary>
        ///     A log4net logger instance. By default a console logger that logs INFO-level messages, but you can set your own
        ///     configured logger.
        /// </summary>
        public ILog Logger { get; set; }

        private readonly string api_key;
        private readonly string username;
        private readonly string password;
        private readonly QuoteProvider provider;
        private string token;
        private WebSocket ws;
        private bool ready;
        private readonly ConcurrentQueue<IQuote> queue = new ConcurrentQueue<IQuote>();
        private readonly List<Thread> runningThreads = new List<Thread>();
        private readonly HashSet<string> channels = new HashSet<string>();
        private HashSet<string> joinedChannels = new HashSet<string>();

        private readonly int SELF_HEAL_TIME = 1000;
        private readonly int HEARTBEAT_INTERVAL = 1000;

        private readonly string IEX_HEARTBEAT_MSG =
            "{\"topic\":\"phoenix\",\"event\":\"heartbeat\",\"payload\":{},\"ref\":null}";

        private readonly string CRYPTOQUOTE_HEARTBEAT_MSG =
            "{\"topic\":\"phoenix\",\"event\":\"heartbeat\",\"payload\":{},\"ref\":null}";

        private readonly string FXCM_HEARTBEAT_MSG =
            "{\"topic\":\"phoenix\",\"event\":\"heartbeat\",\"payload\":{},\"ref\":null}";

        #region Public Methods

        /// <summary>
        ///     Initializes a new real-time client instance.
        /// </summary>
        /// <param name="api_key">Your Intrinio API Key</param>
        /// <param name="username">Your Intrinio API Username</param>
        /// <param name="password">Your Intrinio API Password</param>
        /// <param name="provider">A QuoteProvider</param>
        public RealTimeClient(QuoteProvider provider, string username = null, string password = null,
            string api_key = null)
        {
            this.api_key = api_key;
            this.username = username;
            this.password = password;
            this.provider = provider;

            if (String.IsNullOrEmpty(this.api_key))
            {
                if (String.IsNullOrEmpty(this.username) && String.IsNullOrEmpty(this.password))
                    throw new ArgumentException("Must provide an API key or username and password");

                if (String.IsNullOrEmpty(this.username)) throw new ArgumentException("Must provide a valid username");

                if (String.IsNullOrEmpty(this.password)) throw new ArgumentException("Must provide a valid password");
            }

            Logger = LogManager.GetLogger(GetType());

            var heartbeat = new Thread(SendHeartbeat);
            heartbeat.Start();
            runningThreads.Add(heartbeat);
        }

        /// <summary>
        ///     Establishes a WebSocket connection and starts listening for price quotes. Attempts to self-heal if the connection
        ///     is interrupted or dropped. This method will return after a connection is established. You may want to block the
        ///     thread afterwards in order to allow the client to keep listening for prices.
        /// </summary>
        public void Connect()
        {
            Logger.Info("Connecting...");

            ready = false;
            joinedChannels = new HashSet<string>();

            if (ws != null && ws.IsAlive) ws.Close();

            try
            {
                RefreshToken();
                RefreshWebSocket();
            }
            catch (Exception e)
            {
                Logger.Error("Cannot connect", e);
                SelfHeal();
            }
        }

        /// <summary>
        ///     Severs the WebSocket connection and stops listening for quotes.
        /// </summary>
        public void Disconnect()
        {
            ready = false;
            joinedChannels = new HashSet<string>();

            if (ws != null && ws.IsAlive) ws.Close();

            Logger.Info("Disconnected!");
        }

        /// <summary>
        ///     Registers a QuoteHandler instance to handle quotes in the client's queue. Multiple QuoteHandler instances can be
        ///     registered. Quotes will be taken off the queue and given to the next available QuoteHander.
        /// </summary>
        /// <param name="handler">An instance of QuoteHandler</param>
        public void RegisterQuoteHandler(QuoteHandler handler)
        {
            handler.Client = this;
            ThreadStart threadStart = handler.Listen;
            var thread = new Thread(threadStart);
            thread.Start();
            runningThreads.Add(thread);
            Logger.Debug("Registered quote handler");
        }

        /// <summary>
        ///     Blocks until a quote can be dequeued from the queue/
        /// </summary>
        /// <returns>An IQuote</returns>
        public IQuote GetNextQuote()
        {
            IQuote quote = null;
            while (queue.TryDequeue(out quote) != true)
            {
            }

            return quote;
        }

        /// <summary>
        ///     Returns the size of the quote queue. Monitor this to make sure your QuoteHandler instances are not falling behind.
        /// </summary>
        /// <returns>An integer representing the size of the quote queue</returns>
        public int QueueSize()
        {
            return queue.Count;
        }

        /// <summary>
        ///     Listen for price quotes on the given channel.
        /// </summary>
        /// <param name="channel">A channel to join, which may be a security ticker such as "AAPL"</param>
        public void Join(string channel)
        {
            Join(new[] { channel });
        }

        /// <summary>
        ///     Listen for price quotes on the given channels.
        /// </summary>
        /// <param name="channels">The channels to join, which may be a list of security tickers such as "AAPL"</param>
        public void Join(string[] channels)
        {
            foreach (var channel in channels) this.channels.Add(channel);
            RefreshChannels();
        }

        /// <summary>
        ///     Stop listening for price quotes on the given channel.
        /// </summary>
        /// <param name="channel">A channel to leave, which may be a security ticker such as "AAPL"</param>
        public void Leave(string channel)
        {
            Leave(new[] { channel });
        }

        /// <summary>
        ///     Stop listening for price quotes on the given channels.
        /// </summary>
        /// <param name="channels">The channels to leave, which may be a list of security tickers such as "AAPL"</param>
        public void Leave(string[] channels)
        {
            foreach (var channel in channels) this.channels.Remove(channel);
            RefreshChannels();
        }

        /// <summary>
        ///     Stop listening for price quotes on all channels.
        /// </summary>
        public void LeaveAll()
        {
            channels.Clear();
            RefreshChannels();
        }

        /// <summary>
        ///     Stop listening for price quotes on all channels, then start listening for price quotes on the given channels
        /// </summary>
        /// <param name="channels">The channels to join, which may be a list of security tickers such as "AAPL"</param>
        public void SetChannels(string[] channels)
        {
            this.channels.Clear();
            foreach (var channel in channels) this.channels.Add(channel);
            RefreshChannels();
        }

        #endregion

        #region Private Methods

        /// <summary>
        ///     Disposes of the client.
        /// </summary>
        public void Dispose()
        {
            Logger.Debug("Client disposing...");

            Disconnect();

            runningThreads.ForEach(delegate(Thread thread) { thread.Abort(); });
        }

        private void SelfHeal()
        {
            Logger.Info("Retrying connection...");
            Thread.Sleep(SELF_HEAL_TIME);
            Connect();
        }

        private string MakeAuthUrl()
        {
            string url = null;
            if (provider == QuoteProvider.IEX)
                url = "https://realtime.intrinio.com/auth";
            else if (provider == QuoteProvider.QUODD)
                url = "https://api.intrinio.com/token?type=QUODD";
            else if (provider == QuoteProvider.CRYPTOQUOTE)
                url = "https://crypto.intrinio.com/auth";
            else if (provider == QuoteProvider.FXCM) url = "https://fxcm.intrinio.com/auth";

            if (!String.IsNullOrEmpty(url) && !String.IsNullOrEmpty(api_key)) url = MakeUrlAuthUrl(url);

            return url;
        }

        private string MakeUrlAuthUrl(string auth_url)
        {
            if (auth_url.Contains("?"))
                auth_url = auth_url + "&";
            else
                auth_url = auth_url + "?";

            return auth_url + "api_key=" + api_key;
        }

        private void RefreshToken()
        {
            var request = (HttpWebRequest) WebRequest.Create(MakeAuthUrl());

            if (String.IsNullOrEmpty(api_key))
            {
                var encoded =
                    Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
                request.Headers.Add("Authorization", "Basic " + encoded);
            }

            var response = (HttpWebResponse) request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
                using (var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    token = reader.ReadToEnd();
                    Logger.Info("Authorization successful!");
                }
            else
                throw new Exception("Authorization status code: " + response.StatusCode);
        }

        private string MakeWebSocketUrl()
        {
            if (provider == QuoteProvider.IEX)
                return "wss://realtime.intrinio.com/socket/websocket?vsn=1.0.0&token=" + token;

            if (provider == QuoteProvider.QUODD) return "wss://www5.quodd.com/websocket/webStreamer/intrinio/" + token;

            if (provider == QuoteProvider.CRYPTOQUOTE)
                return "wss://crypto.intrinio.com/socket/websocket?vsn=1.0.0&token=" + token;

            if (provider == QuoteProvider.FXCM)
                return "wss://fxcm.intrinio.com/socket/websocket?vsn=1.0.0&token=" + token;

            return null;
        }

        private void RefreshWebSocket()
        {
            ws = new WebSocket(MakeWebSocketUrl());

            ws.OnOpen += (sender, e) =>
            {
                Logger.Info("Websocket connected!");
                if (provider == QuoteProvider.IEX || provider == QuoteProvider.CRYPTOQUOTE ||
                    provider == QuoteProvider.FXCM)

                {
                    ready = true;
                    RefreshChannels();
                }
            };

            ws.OnClose += (sender, e) =>
            {
                Logger.Info("Websocket closed!");
                if (!(e.Code == 1001 || e.Code == 1005)) SelfHeal();
            };

            ws.OnError += (sender, e) => { Logger.Error("Websocket error!", e.Exception); };

            ws.OnMessage += (sender, e) =>
            {
                IQuote quote = null;
                Logger.Info(e.Data);

                var reply_message = JObject.Parse(e.Data);
                var reply_event = reply_message["event"].ToString();
                if (reply_event == "phx_reply")
                {
                    var payload_status = reply_message["payload"]["status"].ToString();
                    var payload_response = reply_message["payload"]["response"].ToString();
                    if (payload_status == "error")
                    {
                        Console.WriteLine(payload_response);
                        Logger.Error("Websocket error! " + payload_response);
                    }
                }
                else if (provider == QuoteProvider.IEX)
                {
                    var message = JsonConvert.DeserializeObject<IexMessage>(e.Data);
                    if (message.Event == "quote") quote = message.Payload;
                }
                else if (provider == QuoteProvider.CRYPTOQUOTE)
                {
                    var message = JsonConvert.DeserializeObject<CryptoquoteMessage>(e.Data);
                    if (message.Event == "book_update") quote = message.Payload.ToObject<CryptoLevel2Message>();
                    if (message.Event == "ticker") quote = message.Payload.ToObject<CryptoLevel1Message>();
                    if (message.Event == "trade") quote = message.Payload.ToObject<CryptoLevel1Message>();
                }
                else if (provider == QuoteProvider.FXCM)
                {
                    var message = JsonConvert.DeserializeObject<FxcmMessage>(e.Data);
                    if (message.Event == "price_update")
                        //quote = message.Payload;
                        quote = message.Payload.ToObject<FxcmPrice>();
                }
                else if (provider == QuoteProvider.QUODD)
                {
                    var message = JsonConvert.DeserializeObject<QuoddMessage>(e.Data);
                    if (message.Event == "info")
                    {
                        var info = message.Data.ToObject<QuoddInfoData>();
                        if (info.Message == "Connected")
                        {
                            ready = true;
                            RefreshChannels();
                        }
                        else
                        {
                            Logger.Info(info.Message);
                        }
                    }
                    else if (message.Event == "quote")
                    {
                        quote = message.Data.ToObject<QuoddBookQuote>();
                    }
                    else if (message.Event == "trade")
                    {
                        quote = message.Data.ToObject<QuoddTradeQuote>();
                    }
                }

                if (quote != null)
                {
                    Logger.Debug("Websocket quote received: " + quote);
                    queue.Enqueue(quote);
                }
                else
                {
                    Logger.Debug("Websocket non-quote message: " + e.Data);
                }
            };

            ws.Connect();
        }

        private void RefreshChannels()
        {
            if (!ready) return;

            if (channels.Count == 00 && joinedChannels.Count == 0) return;

            // Join new channels
            var newChannels = new HashSet<string>(channels);
            Logger.Debug("New channels: " + String.Join(", ", newChannels));
            foreach (var channel in joinedChannels) newChannels.Remove(channel);
            foreach (var channel in newChannels)
            {
                var msg = MakeJoinMessage(channel);
                ws.Send(msg);
                Logger.Info("Joined channel " + channel);
            }

            // Leave old channels
            var oldChannels = new HashSet<string>(joinedChannels);
            Logger.Debug("Old channels: " + String.Join(", ", oldChannels));
            foreach (var channel in channels) oldChannels.Remove(channel);
            foreach (var channel in oldChannels)
            {
                var msg = MakeLeaveMessage(channel);
                ws.Send(msg);
                Logger.Info("Left channel " + channel);
            }

            joinedChannels = new HashSet<string>(channels);
            Logger.Debug("Current channels: " + String.Join(", ", joinedChannels));
        }

        private string MakeLeaveMessage(string channel)
        {
            var message = "";

            if (provider == QuoteProvider.IEX)
                message = "{\"topic\":\"" + ParseIexTopic(channel) +
                          "\",\"event\":\"phx_leave\",\"payload\":{},\"ref\":null}";
            else if (provider == QuoteProvider.CRYPTOQUOTE)
                message = "{\"topic\":\"" + channel + "\",\"event\":\"phx_leave\",\"payload\":{},\"ref\":null}";
            else if (provider == QuoteProvider.QUODD)
                message = "{\"event\": \"unsubscribe\", \"data\": { \"ticker\": " + channel +
                          ", \"action\": \"unsubscribe\"}}";

            return message;
        }

        private string MakeJoinMessage(string channel)
        {
            var message = "";

            if (provider == QuoteProvider.IEX)
                message = "{\"topic\":\"" + ParseIexTopic(channel) +
                          "\",\"event\":\"phx_join\",\"payload\":{},\"ref\":null}";
            else if (provider == QuoteProvider.CRYPTOQUOTE)
                message = "{\"topic\":\"" + channel + "\",\"event\":\"phx_join\",\"payload\":{},\"ref\":null}";
            else if (provider == QuoteProvider.FXCM)
                message = "{\"topic\":\"" + channel + "\",\"event\":\"phx_join\",\"payload\":{},\"ref\":null}";
            else if (provider == QuoteProvider.QUODD)
                message = "{\"event\": \"subscribe\", \"data\": { \"ticker\": " + channel +
                          ", \"action\": \"subscribe\"}}";

            return message;
        }

        private string ParseIexTopic(string channel)
        {
            switch (channel)
            {
                case "$lobby":
                    return "iex:lobby";
                case "$lobby_last_price":
                    return "iex:lobby:last_price";
                default:
                    return "iex:securities:" + channel;
            }
        }

        private void SendHeartbeat()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(HEARTBEAT_INTERVAL);
                    if (ws != null && ws.IsAlive)
                    {
                        Logger.Debug("Sending heartbeat");
                        if (provider == QuoteProvider.IEX || provider == QuoteProvider.CRYPTOQUOTE ||
                            provider == QuoteProvider.FXCM)
                        {
                            ws.Send("{\"topic\":\"phoenix\",\"event\":\"heartbeat\",\"payload\":{},\"ref\":null}");
                        }
                        else if (provider == QuoteProvider.QUODD)
                        {
                            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                            var timestamp = (DateTime.UtcNow - epoch).TotalMilliseconds;
                            ws.Send("{\"event\": \"heartbeat\", \"data\": {\"action\": \"heartbeat\", \"ticker\": " +
                                    timestamp + "}}");
                        }
                    }
                }
            }
            catch (ThreadAbortException e)
            {
            }
        }

        #endregion
    }
}