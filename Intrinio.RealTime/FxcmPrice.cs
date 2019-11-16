using Newtonsoft.Json;

namespace Intrinio.RealTime
{
    /// <summary>
    /// A price update message from FXCM
    /// </summary>
    public class FxcmPrice : IQuote
    {
        /// <summary>
        /// The UTC timestamp of when the data was last updated
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; }

        /// <summary>
        /// The code of the fx currency pair
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; }

        /// <summary>
        /// The bid price of the fx currency pair
        /// </summary>
        [JsonProperty("bid_price")]
        public float? BidPrice { get; }

        /// <summary>
        /// The ask price of the fx currency pair
        /// </summary>
        [JsonProperty("ask_price")]
        public float? AskPrice { get; }


        /// <summary>
        /// Initializes a FxcmPrice
        /// </summary>
        /// <param name="time">The UTC timestamp of the price update</param>
        /// <param name="code">The code of the fx currency pair</param>
        /// <param name="bidPrice">The bid price of the fx currency pair</param>
        /// <param name="askPrice">The ask price of the fx currency pair</param>
        public FxcmPrice(string time, string code, float? bidPrice, float? askPrice)
        {
            Time = time;
            Code = code;
            BidPrice = bidPrice;
            AskPrice = askPrice;
        }

        /// <summary>
        /// Returns a string representation of the price update
        /// </summary>
        /// <returns>A string representation of the price update</returns>
        public override string ToString()
        {
            return "Intrinio.FxcmPrice(Time: " + Time +
                   ", Code: " + Code +
                   ", BidPrice: " + BidPrice +
                   ", AskPrice: " + AskPrice + ")";
        }
    }
}