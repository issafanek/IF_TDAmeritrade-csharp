using System;
using Newtonsoft.Json;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.Quotes.Models
{
    public class ETF
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("bidPrice")]
        public decimal BidPrice { get; set; }

        [JsonProperty("bidSize")]
        public Int64 BidSize { get; set; }

        [JsonProperty("bidId")]
        public string BidId { get; set; }

        [JsonProperty("askPrice")]
        public decimal AskPrice { get; set; }

        [JsonProperty("askSize")]
        public Int64 AskSize { get; set; }

        [JsonProperty("askId")]
        public string AskId { get; set; }

        [JsonProperty("lastPrice")]
        public decimal LastPrice { get; set; }

        [JsonProperty("lastSize")]
        public Int64 LastSize { get; set; }

        [JsonProperty("lastId")]
        public string LastId { get; set; }

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

        [JsonProperty("quoteTimeInLong")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime QuoteTime { get; set; }

        [JsonProperty("tradeTimeInLong")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime TradeTime { get; set; }

        [JsonProperty("mark")]
        public decimal Mark { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonProperty("marginable")]
        public bool Marginable { get; set; }

        [JsonProperty("shortable")]
        public bool Shortable { get; set; }

        [JsonProperty("volatility")]
        public decimal Volatility { get; set; }

        [JsonProperty("digits")]
        public Int64 Digits { get; set; }

        [JsonProperty("52WkHigh")]
        public decimal The52WkHigh { get; set; }

        [JsonProperty("52WkLow")]
        public decimal The52WkLow { get; set; }

        [JsonProperty("peRatio")]
        public decimal PeRatio { get; set; }

        [JsonProperty("divAmount")]
        public decimal DivAmount { get; set; }

        [JsonProperty("divYield")]
        public decimal DivYield { get; set; }

        [JsonProperty("divDate")]
        public DateTime DivDate { get; set; }

        [JsonProperty("securityStatus")]
        public string SecurityStatus { get; set; }

        [JsonProperty("regularMarketLastPrice")]
        public decimal RegularMarketLastPrice { get; set; }

        [JsonProperty("regularMarketLastSize")]
        public Int64 RegularMarketLastSize { get; set; }

        [JsonProperty("regularMarketNetChange")]
        public decimal RegularMarketNetChange { get; set; }

        [JsonProperty("regularMarketTradeTimeInLong")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime RegularMarketTradeTime { get; set; }
    }
}