﻿using System;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.RealTime
{
    /// <summary>
    /// A Trade Quote from QUODD
    /// </summary>
    public class QuoddTradeQuote : IQuote
    {

        /// <summary>
        /// The difference between the closing price of a security on the current trading day and the previous day's closing price.
        /// </summary>
        [JsonProperty("change_price_4d")]
        public Int64? ChangePrice4d { get; }

        /// <summary>
        /// A security's intra-day high trading price.
        /// </summary>
        [JsonProperty("day_high_4d")]
        public Int64? DayHigh4d { get; }

        /// <summary>
        /// Time that the security reached a new high
        /// </summary>
        [JsonProperty("day_high_time")]
        public Int64? DayHighTime { get; }

        /// <summary>
        /// A security's intra-day low trading price.
        /// </summary>
        [JsonProperty("day_low_4d")]
        public Int64? DayLow4d { get; }

        /// <summary>
        /// Time that the security reached a new low
        /// </summary>
        [JsonProperty("day_low_time")]
        public Int64? DayLowTime { get; }

        /// <summary>
        /// Extended hours change price (pre or post market)
        /// </summary>
        [JsonProperty("ext_change_price_4d")]
        public Int64? ExtChangePrice4d { get; }

        /// <summary>
        /// Extended hours last price (pre or post market)
        /// </summary>
        [JsonProperty("ext_last_price_4d")]
        public Int64? ExtLastPrice4d { get; }

        /// <summary>
        /// Extended hours percent change (pre or post market)
        /// </summary>
        [JsonProperty("ext_percent_change_4d")]
        public Int64? ExtPercentChange4d { get; }

        /// <summary>
        /// Extended hours exchange where last trade took place (Pre or post market)
        /// </summary>
        [JsonProperty("ext_trade_exchange")]
        public String ExtTradeExchange { get; }

        /// <summary>
        /// Time of the extended hours trade in milliseconds
        /// </summary>
        [JsonProperty("ext_trade_time")]
        public Int64? ExtTradeTime { get; }

        /// <summary>
        /// The amount of shares traded for a single extended hours trade
        /// </summary>
        [JsonProperty("ext_trade_volume")]
        public Int64? ExtTradeVolume { get; }

        /// <summary>
        /// Extended hours tick indicator - up or down
        /// </summary>
        [JsonProperty("ext_up_down")]
        public String ExtUpDown { get; }

        /// <summary>
        /// A flag indicating that the stock is halted and not currently trading
        /// </summary>
        [JsonProperty("is_halted")]
        public Boolean? IsHalted { get; }

        /// <summary>
        /// A flag indicating the stock is current short sale restricted - meaning you can not short sale the stock when true
        /// </summary>
        [JsonProperty("is_short_restricted")]
        public Boolean? IsShortRestricted { get; }

        /// <summary>
        /// The price at which the security most recently traded
        /// </summary>
        [JsonProperty("last_price_4d")]
        public Int64? LastPrice4d { get; }

        /// <summary>
        /// The price at which a security first trades upon the opening of an exchange on a given trading day
        /// </summary>
        [JsonProperty("open_price_4d")]
        public Int64? OpenPrice4d { get; }

        /// <summary>
        /// The time at which the security opened in milliseconds
        /// </summary>
        [JsonProperty("open_time")]
        public Int64? OpenTime { get; }

        /// <summary>
        /// The number of shares that that were traded on the opening trade
        /// </summary>
        [JsonProperty("open_volume")]
        public Int64? OpenVolume { get; }

        /// <summary>
        /// The percentage at which the security is up or down since the previous day's trading
        /// </summary>
        [JsonProperty("percent_change_4d")]
        public Int64? PercentChange4d { get; }

        /// <summary>
        /// The security's closing price on the preceding day of trading
        /// </summary>
        [JsonProperty("prev_close_4d")]
        public Int64? PrevClose4d { get; }

        /// <summary>
        /// Internal Quodd ID defining Source of Data
        /// </summary>
        [JsonProperty("protocol_id")]
        public Int64? ProtocolId { get; }

        /// <summary>
        /// Underlying symbol for a particular contract
        /// </summary>
        [JsonProperty("root_ticker")]
        public String RootTicker { get; }

        /// <summary>
        /// Record Transaction Level - number of records published that day
        /// </summary>
        [JsonProperty("rtl")]
        public Int64? Rtl { get; }

        /// <summary>
        /// Stock Symbol for the security
        /// </summary>
        [JsonProperty("ticker")]
        public String Ticker { get; }

        /// <summary>
        /// The accumulated total amount of shares traded
        /// </summary>
        [JsonProperty("total_volume")]
        public Int64? TotalVolume { get; }

        /// <summary>
        /// The market center where the last trade occurred
        /// </summary>
        [JsonProperty("trade_exchange")]
        public String TradeExchange { get; }

        /// <summary>
        /// The time at which the security last traded in milliseconds
        /// </summary>
        [JsonProperty("trade_time")]
        public Int64? TradeTime { get; }

        /// <summary>
        /// The number of shares that that were traded on the last trade
        /// </summary>
        [JsonProperty("trade_volume")]
        public Int64? TradeVolume { get; }

        /// <summary>
        /// Tick indicator - up or down - indicating if the last trade was up or down from the previous trade
        /// </summary>
        [JsonProperty("up_down")]
        public String UpDown { get; }

        /// <summary>
        /// NASDAQ volume plus the volumes from other market centers to more accurately match composite volume. Used for NASDAQ Basic
        /// </summary>
        [JsonProperty("volume_plus")]
        public Int64? VolumePlus { get; }

        /// <summary>
        /// Volume weighted Average Price. VWAP is calculated by adding up the dollars traded for every transaction (price multiplied by number of shares traded) and then dividing by the total shares traded for the day.
        /// </summary>
        [JsonProperty("vwap_4d")]
        public Int64? Vwap4d { get; }

        /// <summary>
        /// Initializes an QuoddTradeQuote
        /// </summary>
        public QuoddTradeQuote(Int64? ChangePrice4d, Int64? DayHigh4d, Int64? DayHighTime, Int64? DayLow4d, Int64? DayLowTime, Int64? ExtChangePrice4d, Int64? ExtLastPrice4d, Int64? ExtPercentChange4d, String ExtTradeExchange, Int64? ExtTradeTime, Int64? ExtTradeVolume, String ExtUpDown, Boolean? IsHalted, Boolean? IsShortRestricted, Int64? LastPrice4d, Int64? OpenPrice4d, Int64? OpenTime, Int64? OpenVolume, Int64? PercentChange4d, Int64? PrevClose4d, Int64? ProtocolId, String RootTicker, Int64? Rtl, String Ticker, Int64? TotalVolume, String TradeExchange, Int64? TradeTime, Int64? TradeVolume, String UpDown, Int64? VolumePlus, Int64? Vwap4d)
        {
            this.ChangePrice4d = ChangePrice4d;
            this.DayHigh4d = DayHigh4d;
            this.DayHighTime = DayHighTime;
            this.DayLow4d = DayLow4d;
            this.DayLowTime = DayLowTime;
            this.ExtChangePrice4d = ExtChangePrice4d;
            this.ExtLastPrice4d = ExtLastPrice4d;
            this.ExtPercentChange4d = ExtPercentChange4d;
            this.ExtTradeExchange = ExtTradeExchange;
            this.ExtTradeTime = ExtTradeTime;
            this.ExtTradeVolume = ExtTradeVolume;
            this.ExtUpDown = ExtUpDown;
            this.IsHalted = IsHalted;
            this.IsShortRestricted = IsShortRestricted;
            this.LastPrice4d = LastPrice4d;
            this.OpenPrice4d = OpenPrice4d;
            this.OpenTime = OpenTime;
            this.OpenVolume = OpenVolume;
            this.PercentChange4d = PercentChange4d;
            this.PrevClose4d = PrevClose4d;
            this.ProtocolId = ProtocolId;
            this.RootTicker = RootTicker;
            this.Rtl = Rtl;
            this.Ticker = Ticker;
            this.TotalVolume = TotalVolume;
            this.TradeExchange = TradeExchange;
            this.TradeTime = TradeTime;
            this.TradeVolume = TradeVolume;
            this.UpDown = UpDown;
            this.VolumePlus = VolumePlus;
            this.Vwap4d = Vwap4d;
        }

        /// <summary>
        /// Returns a string representation of the quote
        /// </summary>
        /// <returns>A string representation of the quote</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Intrinio.QuoddTradeQuote(");

            if (Ticker != null)
            {
                result.Append("Ticker: ").Append(Ticker);
            }
            if (ChangePrice4d != null)
            {
                result.Append(", ChangePrice4d: ").Append(ChangePrice4d);
            }
            if (DayHigh4d != null)
            {
                result.Append(", DayHigh4d: ").Append(DayHigh4d);
            }
            if (DayHighTime != null)
            {
                result.Append(", DayHighTime: ").Append(DayHighTime);
            }
            if (DayLow4d != null)
            {
                result.Append(", DayLow4d: ").Append(DayLow4d);
            }
            if (DayLowTime != null)
            {
                result.Append(", DayLowTime: ").Append(DayLowTime);
            }
            if (ExtChangePrice4d != null)
            {
                result.Append(", ExtChangePrice4d: ").Append(ExtChangePrice4d);
            }
            if (ExtLastPrice4d != null)
            {
                result.Append(", ExtLastPrice4d: ").Append(ExtLastPrice4d);
            }
            if (ExtPercentChange4d != null)
            {
                result.Append(", ExtPercentChange4d: ").Append(ExtPercentChange4d);
            }
            if (ExtTradeExchange != null)
            {
                result.Append(", ExtTradeExchange: ").Append(ExtTradeExchange);
            }
            if (ExtTradeTime != null)
            {
                result.Append(", ExtTradeTime: ").Append(ExtTradeTime);
            }
            if (ExtTradeVolume != null)
            {
                result.Append(", ExtTradeVolume: ").Append(ExtTradeVolume);
            }
            if (ExtUpDown != null)
            {
                result.Append(", ExtUpDown: ").Append(ExtUpDown);
            }
            if (IsHalted != null)
            {
                result.Append(", IsHalted: ").Append(IsHalted);
            }
            if (IsShortRestricted != null)
            {
                result.Append(", IsShortRestricted: ").Append(IsShortRestricted);
            }
            if (LastPrice4d != null)
            {
                result.Append(", LastPrice4d: ").Append(LastPrice4d);
            }
            if (OpenPrice4d != null)
            {
                result.Append(", OpenPrice4d: ").Append(OpenPrice4d);
            }
            if (OpenTime != null)
            {
                result.Append(", OpenTime: ").Append(OpenTime);
            }
            if (OpenVolume != null)
            {
                result.Append(", OpenVolume: ").Append(OpenVolume);
            }
            if (PercentChange4d != null)
            {
                result.Append(", PercentChange4d: ").Append(PercentChange4d);
            }
            if (PrevClose4d != null)
            {
                result.Append(", PrevClose4d: ").Append(PrevClose4d);
            }
            if (ProtocolId != null)
            {
                result.Append(", ProtocolId: ").Append(ProtocolId);
            }
            if (RootTicker != null)
            {
                result.Append(", RootTicker: ").Append(RootTicker);
            }
            if (Rtl != null)
            {
                result.Append(", Rtl: ").Append(Rtl);
            }
            if (TotalVolume != null)
            {
                result.Append(", TotalVolume: ").Append(TotalVolume);
            }
            if (TradeExchange != null)
            {
                result.Append(", TradeExchange: ").Append(TradeExchange);
            }
            if (TradeTime != null)
            {
                result.Append(", TradeTime: ").Append(TradeTime);
            }
            if (TradeVolume != null)
            {
                result.Append(", TradeVolume: ").Append(TradeVolume);
            }
            if (UpDown != null)
            {
                result.Append(", UpDown: ").Append(UpDown);
            }
            if (VolumePlus != null)
            {
                result.Append(", VolumePlus: ").Append(VolumePlus);
            }
            if (Vwap4d != null)
            {
                result.Append(", Vwap4d: ").Append(Vwap4d);
            }

            result.Append(")");

            return result.ToString();
        }
    }
}