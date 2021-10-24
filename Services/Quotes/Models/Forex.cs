using System;
using Newtonsoft.Json;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.Quotes.Models
{
    public class Forex
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("bidPriceInDouble")]
        public decimal BidPrice { get; set; }

        [JsonProperty("askPriceInDouble")]
        public decimal AskPrice { get; set; }

        [JsonProperty("lastPriceInDouble")]
        public decimal LastPrice{ get; set; }

        [JsonProperty("highPriceInDouble")]
        public decimal HighPrice{ get; set; }

        [JsonProperty("lowPriceInDouble")]
        public decimal LowPrice{ get; set; }

        [JsonProperty("closePriceInDouble")]
        public decimal ClosePrice{ get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("openPriceInDouble")]
        public decimal OpenPrice{ get; set; }

        [JsonProperty("changeInDouble")]
        public decimal Change{ get; set; }

        [JsonProperty("percentChange")]
        public decimal PercentChange { get; set; }

        [JsonProperty("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonProperty("digits")]
        public Int64  Digits { get; set; }

        [JsonProperty("securityStatus")]
        public string SecurityStatus { get; set; }

        [JsonProperty("tick")]
        public decimal Tick { get; set; }

        [JsonProperty("tickAmount")]
        public decimal TickAmount { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("tradingHours")]
        public string TradingHours { get; set; }

        [JsonProperty("isTradable")]
        public bool IsTradable { get; set; }

        [JsonProperty("marketMaker")]
        public string MarketMaker { get; set; }

        [JsonProperty("52WkHighInDouble")]
        public decimal The52WkHigh{ get; set; }

        [JsonProperty("52WkLowInDouble")]
        public decimal The52WkLow{ get; set; }

        [JsonProperty("mark")]
        public decimal Mark { get; set; }
    }
}