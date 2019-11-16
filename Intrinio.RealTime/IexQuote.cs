namespace Intrinio.RealTime
{
    /// <summary>
    /// A Quote from IEX
    /// </summary>
    public class IexQuote : IQuote
    {
        /// <summary>
        /// The type of quote, either "bid", "ask", or "last"
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// The security ticker
        /// </summary>
        public string Ticker { get; }

        /// <summary>
        /// The quote price
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// The size of the order or trade
        /// </summary>
        public long Size { get; }

        /// <summary>
        /// The unix timestamp of the quote
        /// </summary>
        public decimal Timestamp { get; }

        /// <summary>
        /// Initializes an IexQuote
        /// </summary>
        /// <param name="type">The type of quote, either "bid", "ask", or "last"</param>
        /// <param name="ticker">The security ticker</param>
        /// <param name="price">The quote price</param>
        /// <param name="size">The size of the order or trade</param>
        /// <param name="timestamp">The unix timestamp of the quote</param>
        public IexQuote(string type, string ticker, decimal price, long size, decimal timestamp)
        {
            Type = type;
            Ticker = ticker;
            Price = price;
            Size = size;
            Timestamp = timestamp;
        }

        /// <summary>
        /// Returns a string representation of the quote
        /// </summary>
        /// <returns>A string representation of the quote</returns>
        public override string ToString()
        {
            return "Intrinio.IexQuote(Type: " + Type +
                   ", Ticker: " + Ticker +
                   ", Price: " + Price +
                   ", Size: " + Size +
                   ", Timestamp: " + Timestamp;
        }
    }
}