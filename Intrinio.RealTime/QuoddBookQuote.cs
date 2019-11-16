using System.Text;
using Newtonsoft.Json;

namespace Intrinio.RealTime
{
    /// <summary>
    /// A Book Quote from QUODD
    /// </summary>
    public class QuoddBookQuote : IQuote
    {
        /// <summary>
        /// The amount of a security that a market maker is offering to sell at the ask price
        /// </summary>
        [JsonProperty("ask_size")]
        public long? AskSize { get; }

        /// <summary>
        /// Time of the quote in milliseconds
        /// </summary>
        [JsonProperty("quote_time")]
        public long? QuoteTime { get; }

        /// <summary>
        /// Record Transaction Level - number of records published that day
        /// </summary>
        [JsonProperty("rtl")]
        public long? Rtl { get; }

        /// <summary>
        /// Stock Symbol for the security
        /// </summary>
        [JsonProperty("ticker")]
        public string Ticker { get; }

        /// <summary>
        /// The market center from which the ask is being quoted
        /// </summary>
        [JsonProperty("ask_exchange")]
        public string AskExchange { get; }

        /// <summary>
        /// The price a seller is willing to accept for a security
        /// </summary>
        [JsonProperty("ask_price_4d")]
        public long? AskPrice4d { get; }

        /// <summary>
        /// The market center from which the bid is being quoted
        /// </summary>
        [JsonProperty("bid_exchange")]
        public string BidExchange { get; }

        /// <summary>
        /// A bid price is the price a buyer is willing to pay for a security.
        /// </summary>
        [JsonProperty("bid_price_4d")]
        public long? BidPrice4d { get; }

        /// <summary>
        /// The bid size number of shares being offered for purchase at a specified bid price
        /// </summary>
        [JsonProperty("bid_size")]
        public long? BidSize { get; }

        /// <summary>
        /// Internal Quodd ID defining Source of Data
        /// </summary>
        [JsonProperty("protocol_id")]
        public long? ProtocolId { get; }

        /// <summary>
        /// Underlying symbol for a particular contract
        /// </summary>
        [JsonProperty("root_ticker")]
        public string RootTicker { get; }

        /// <summary>
        /// Initializes an QuoddBookQuote
        /// </summary>
        public QuoddBookQuote(long? askSize, long? quoteTime, long? rtl, string ticker, string askExchange,
            long? askPrice4d, string bidExchange, long? bidPrice4d, long? bidSize, long? protocolId, string rootTicker)
        {
            AskSize = askSize;
            QuoteTime = quoteTime;
            Rtl = rtl;
            Ticker = ticker;
            AskExchange = askExchange;
            AskPrice4d = askPrice4d;
            BidExchange = bidExchange;
            BidPrice4d = bidPrice4d;
            BidSize = bidSize;
            ProtocolId = protocolId;
            RootTicker = rootTicker;
        }

        /// <summary>
        /// Returns a string representation of the quote
        /// </summary>
        /// <returns>A string representation of the quote</returns>
        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("Intrinio.QuoddBookQuote(");

            if (Ticker != null)
            {
                result.Append("Ticker: ").Append(Ticker);
            }

            if (RootTicker != null)
            {
                result.Append(", RootTicker: ").Append(RootTicker);
            }

            if (QuoteTime != null)
            {
                result.Append(", QuoteTime: ").Append(QuoteTime);
            }

            if (AskPrice4d != null)
            {
                result.Append(", AskPrice4d: ").Append(AskPrice4d);
            }

            if (AskSize != null)
            {
                result.Append(", AskSize: ").Append(AskSize);
            }

            if (AskExchange != null)
            {
                result.Append(", AskExchange: ").Append(AskExchange);
            }

            if (BidPrice4d != null)
            {
                result.Append(", BidPrice4d: ").Append(BidPrice4d);
            }

            if (BidSize != null)
            {
                result.Append(", BidSize: ").Append(BidSize);
            }

            if (ProtocolId != null)
            {
                result.Append(", ProtocolId: ").Append(ProtocolId);
            }

            if (BidExchange != null)
            {
                result.Append(", BidExchange: ").Append(BidExchange);
            }

            if (Rtl != null)
            {
                result.Append(", Rtl: ").Append(Rtl);
            }

            result.Append(")");

            return result.ToString();
        }
    }
}