using System;
using Newtonsoft.Json;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.Quotes.Models
{
    public class Index
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastPrice")]
        public decimal LastPrice { get; set; }

        [JsonProperty("openPrice")]
        public decimal OpenPrice { get; set; }

        [JsonProperty("highPrice")]
        public decimal HighPrice { get; set; }

        [JsonProperty("lowPrice")]
        public decimal LowPrice { get; set; }

        [JsonProperty("closePrice")]
        public decimal ClosePrice { get; set; }

        [JsonProperty("netChange")]
        public decimal NetChange { get; set; }

        [JsonProperty("totalVolume")]
        public Int64 TotalVolume { get; set; }

        [JsonProperty("tradeTimeInLong")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime TradeTime { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonProperty("digits")]
        public Int64 Digits { get; set; }

        [JsonProperty("52WkHigh")]
        public decimal The52WkHigh { get; set; }

        [JsonProperty("52WkLow")]
        public decimal The52WkLow { get; set; }

        [JsonProperty("securityStatus")]
        public string SecurityStatus { get; set; }
    }
}