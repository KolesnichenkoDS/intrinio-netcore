using System;
using Newtonsoft.Json;

namespace Intrinio.RealTime
{
    /// <summary>
    /// A Level 1 (price update) message from Cryptoquote
    /// </summary>
    public class CryptoLevel1Message : IQuote
    {
        /// <summary>
        /// The UTC timestamp of when the data was last updated
        /// </summary>
        [JsonProperty("last_updated")]
        public string LastUpdated { get; }

        /// <summary>
        /// The code of the crypto currency pair
        /// </summary>
        [JsonProperty("pair_code")]
        public string PairCode { get; }

        /// <summary>
        /// The code of the crypto currency pair
        /// </summary>
        [JsonProperty("pair_name")]
        public string PairName { get; }

        /// <summary>
        /// The code of the crypto exchange
        /// </summary>
        [JsonProperty("exchange_code")]
        public string ExchangeCode { get; }

        /// <summary>
        /// The name of the crypto exchange
        /// </summary>
        [JsonProperty("exchange_name")]
        public string ExchangeName { get; }

        /// <summary>
        /// The bid price of the crypto currency pair
        /// </summary>
        [JsonProperty("bid")]
        public float? Bid { get; }

        /// <summary>
        /// The bid size of the crypto currency pair
        /// </summary>
        [JsonProperty("bid_size")]
        public float? BidSize { get; }

        /// <summary>
        /// The ask price of the crypto currency pair
        /// </summary>
        [JsonProperty("ask")]
        public float? Ask { get; }

        /// <summary>
        /// The ask size of the crypto currency pair
        /// </summary>
        [JsonProperty("ask_size")]
        public float? AskSize { get; }

        /// <summary>
        /// The notional change in price
        /// </summary>
        [JsonProperty("change")]
        public float? Change { get; }

        /// <summary>
        /// The percent change in price
        /// </summary>
        [JsonProperty("change_percent")]
        public float? ChangePercent { get; }

        /// <summary>
        /// The volume of the crypto currency pair on the exchange
        /// </summary>
        [JsonProperty("volume")]
        public float? Volume { get; }

        /// <summary>
        /// The open price of the crypto currency pair on the exchange
        /// </summary>
        [JsonProperty("open")]
        public float? Open { get; }

        /// <summary>
        /// The high price of the crypto currency pair on the exchange
        /// </summary>
        [JsonProperty("high")]
        public float? High { get; }

        /// <summary>
        /// The low price of the crypto currency pair on the exchange
        /// </summary>
        [JsonProperty("low")]
        public float? Low { get; }

        /// <summary>
        /// A UTC timestamp of the last trade time of the crypto currency pair on the exchange
        /// </summary>
        [JsonProperty("last_trade_time")]
        public string LastTradeTime { get; }

        /// <summary>
        /// The last trade side of the crypto currency pair on the exchange, either "buy" or "sell"
        /// </summary>
        [JsonProperty("last_trade_side")]
        public string LastTradeSide { get; }

        /// <summary>
        /// The last trade price of the crypto currency pair on the exchange
        /// </summary>
        [JsonProperty("last_trade_price")]
        public float? LastTradePrice { get; }

        /// <summary>
        /// The last trade size of the crypto currency pair on the exchange
        /// </summary>
        [JsonProperty("last_trade_size")]
        public float? LastTradeSize { get; }

        /// <summary>
        /// The type of quote, either "book_update", "ticker", or "trade"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; }

        /// <summary>
        /// Initializes a CryptoTicker
        /// </summary>
        /// <param name="lastUpdated">The UTC timestamp of when the ticker data was last updated</param>
        /// <param name="pairCode">The code of the crypto currency pair</param>
        /// <param name="pairName">The name of the crypto currency pair</param>
        /// <param name="exchangeCode">The code fo the crypto exchange</param>
        /// <param name="exchangeName">The name of the crypto exchange</param>
        /// <param name="bid">The bid price of the crypto currency pair</param>
        /// <param name="bidSize">The bid size of the crypto currency pair</param>
        /// <param name="ask">The ask price of the crypto currency pair</param>
        /// <param name="askSize">The ask size of the crypto currency pair</param>
        /// <param name="change">The notional change in price"</param>
        /// <param name="changePercent">The percent change in price</param>
        /// <param name="volume">The volume of the crypto currency pair on the exchange</param>
        /// <param name="open">The open price of the crypto currency pair on the exchange</param>
        /// <param name="high">The high price of the crypto currency pair on the exchange</param>
        /// <param name="low">The low price of the crypto currency pair on the exchange</param>
        /// <param name="lastTradeTime">A UTC timestamp of the last trade time of the crypto currency pair on the exchange</param>
        /// <param name="lastTradeSide">The last trade side of the crypto currency pair on the exchange, either "buy" or "sell"</param>
        /// <param name="lastTradePrice">The last trade price of the crypto currency pair on the exchange</param>
        /// <param name="lastTradeSize">The last trade size of the crypto currency pair on the exchange</param>
        /// <param name="type">The type of quote, either "book_update", "ticker", or "trade"</param>
        public CryptoLevel1Message(string lastUpdated, string pairCode, string pairName, string exchangeCode,
            string exchangeName, float? bid, float? bidSize, float? ask, float? askSize, float? change,
            float? changePercent, float? volume, float? open, float? high, float? low, string lastTradeTime,
            string lastTradeSide, float? lastTradePrice, float? lastTradeSize, string type)
        {
            LastUpdated = lastUpdated;
            PairCode = pairCode;
            PairName = pairName;
            ExchangeCode = exchangeCode;
            ExchangeName = exchangeName;
            Bid = bid;
            BidSize = bidSize;
            Ask = ask;
            AskSize = askSize;
            Change = change;
            ChangePercent = changePercent;
            Volume = volume;
            Open = open;
            High = high;
            Low = low;
            LastTradeTime = lastTradeTime;
            LastTradeSide = lastTradeSide;
            LastTradePrice = lastTradePrice;
            LastTradeSize = lastTradeSize;
            Type = type;
        }

        /// <summary>
        /// Returns a string representation of the ticker
        /// </summary>
        /// <returns>A string representation of the ticker</returns>
        public override string ToString()
        {
            return "Intrinio.CryptoTicker(Type: " + Type +
                   ", LastUpdated: " + LastUpdated +
                   ", PairName: " + PairName +
                   ", PairCode: " + PairCode +
                   ", ExchangeName: " + ExchangeName +
                   ", ExchangeCode: " + ExchangeCode +
                   ", Bid: " + Bid +
                   ", BidSize: " + BidSize +
                   ", Ask: " + Ask +
                   ", AskSize: " + AskSize +
                   ", Change: " + Change +
                   ", ChangePercent: " + ChangePercent +
                   ", Volume: " + Volume +
                   ", Open: " + Open +
                   ", High: " + High +
                   ", Low: " + Low +
                   ", LastTradeTime: " + LastTradeTime +
                   ", LastTradeSide: " + LastTradeSide +
                   ", LastTradePrice: " + LastTradePrice +
                   ", LastTradeSize: " + LastTradeSize + ")";
        }
    }
}