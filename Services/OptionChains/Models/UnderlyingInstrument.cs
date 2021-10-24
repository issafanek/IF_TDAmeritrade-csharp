using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Shared.Utilities.Extensions;
using TDAmeritrade.Services.OptionChains.Types;

namespace TDAmeritrade.Services.OptionChains.Models
{
    public class UnderlyingInstrument
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("change")]
        public decimal Change { get; set; }

        [JsonProperty("percentChange")]
        public decimal PercentChange { get; set; }

        [JsonProperty("close")]
        public decimal Close { get; set; }

        [JsonProperty("quoteTime")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime QuoteTime { get; set; }

        [JsonProperty("tradeTime")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime TradeTime { get; set; }

        [JsonProperty("bid")]
        public decimal Bid { get; set; }

        [JsonProperty("ask")]
        public decimal Ask { get; set; }

        [JsonProperty("last")]
        public decimal Last { get; set; }

        [JsonProperty("mark")]
        public decimal Mark { get; set; }

        [JsonProperty("markChange")]
        public decimal MarkChange { get; set; }

        [JsonProperty("markPercentChange")]
        public decimal MarkPercentChange { get; set; }

        [JsonProperty("bidSize")]
        public Int64 BidSize { get; set; }

        [JsonProperty("askSize")]
        public Int64 AskSize { get; set; }

        [JsonProperty("highPrice")]
        public decimal HighPrice { get; set; }

        [JsonProperty("lowPrice")]
        public decimal LowPrice { get; set; }

        [JsonProperty("openPrice")]
        public decimal OpenPrice { get; set; }

        [JsonProperty("totalVolume")]
        public Int64 TotalVolume { get; set; }

        [JsonProperty("exchangeName")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ExchangeName ExchangeName { get; set; }

        [JsonProperty("fiftyTwoWeekHigh")]
        public decimal FiftyTwoWeekHigh { get; set; }

        [JsonProperty("fiftyTwoWeekLow")]
        public decimal FiftyTwoWeekLow { get; set; }

        [JsonProperty("delayed")]
        public bool Delayed { get; set; }
    }
}