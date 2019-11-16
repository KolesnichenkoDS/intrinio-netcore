using System;
using Newtonsoft.Json;

namespace Intrinio.RealTime
{
    /// <summary>
    /// A Level 2 (book update) message from Cryptoquote
    /// </summary>
    public class CryptoLevel2Message : IQuote
    {
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
        /// The price of the crypto currency pair of the book update
        /// </summary>
        [JsonProperty("price")]
        public float Price { get; }

        /// <summary>
        /// The side of the book update, either "buy" or "sell"
        /// </summary>
        [JsonProperty("side")]
        public string Side { get; }

        /// <summary>
        /// The size of the book update
        /// </summary>
        [JsonProperty("size")]
        public float Size { get; }

        /// <summary>
        /// The type of quote, either "book_update", "ticker", or "trade"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; }

        /// <summary>
        /// Initializes a CryptoBookUpdate
        /// </summary>
        /// <param name="pairCode">The code of the crypto currency pair</param>
        /// <param name="pairName">The name of the crypto currency pair</param>
        /// <param name="exchangeCode">The code fo the crypto exchange</param>
        /// <param name="exchangeName">The name of the crypto exchange</param>
        /// <param name="price">The price of the crypto currency pair of the book update</param>
        /// <param name="side">The side of the book update, either "buy" or "sell"</param>
        /// <param name="size">The size of the book update</param>
        /// <param name="type">The type of quote, either "book_update", "ticker", or "trade"</param>
        public CryptoLevel2Message(string pairCode, string pairName, string exchangeCode, string exchangeName,
            float price, string side, float size, string type)
        {
            PairCode = pairCode;
            PairName = pairName;
            ExchangeCode = exchangeCode;
            ExchangeName = exchangeName;
            Price = price;
            Size = size;
            Side = side;
            Type = type;
        }

        /// <summary>
        /// Returns a string representation of the book_update
        /// </summary>
        /// <returns>A string representation of the book_update</returns>
        public override string ToString()
        {
            return "Intrinio.CryptoBookUpdate(Type: " + Type +
                   ", PairName: " + PairName +
                   ", PairCode: " + PairCode +
                   ", ExchangeName: " + ExchangeName +
                   ", ExchangeCode: " + ExchangeCode +
                   ", Price: " + Price +
                   ", Size: " + Size +
                   ", Side: " + Side + ")";
        }
    }
}