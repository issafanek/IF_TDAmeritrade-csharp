using System;
using Newtonsoft.Json;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.Quotes.Models
{
    public class Option
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("bidPrice")]
        public decimal BidPrice { get; set; }

        [JsonProperty("bidSize")]
        public Int64 BidSize { get; set; }

        [JsonProperty("askPrice")]
        public decimal AskPrice { get; set; }

        [JsonProperty("askSize")]
        public Int64 AskSize { get; set; }

        [JsonProperty("lastPrice")]
        public decimal LastPrice { get; set; }

        [JsonProperty("lastSize")]
        public Int64 LastSize { get; set; }

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

        [JsonProperty("openInterest")]
        public decimal OpenInterest { get; set; }

        [JsonProperty("volatility")]
        public decimal Volatility { get; set; }

        [JsonProperty("moneyIntrinsicValue")]
        public decimal MoneyIntrinsicValue { get; set; }

        [JsonProperty("multiplier")]
        public decimal Multiplier { get; set; }

        [JsonProperty("strikePrice")]
        public decimal StrikePrice { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("underlying")]
        public string Underlying { get; set; }

        [JsonProperty("timeValue")]
        public decimal TimeValue { get; set; }

        [JsonProperty("deliverables")]
        public string Deliverables { get; set; }

        [JsonProperty("delta")]
        public decimal Delta { get; set; }

        [JsonProperty("gamma")]
        public decimal Gamma { get; set; }

        [JsonProperty("theta")]
        public decimal Theta { get; set; }

        [JsonProperty("vega")]
        public decimal Vega { get; set; }

        [JsonProperty("rho")]
        public decimal Rho { get; set; }

        [JsonProperty("securityStatus")]
        public string SecurityStatus { get; set; }

        [JsonProperty("theoreticalOptionValue")]
        public decimal TheoreticalOptionValue { get; set; }

        [JsonProperty("underlyingPrice")]
        public decimal UnderlyingPrice { get; set; }

        [JsonProperty("uvExpirationType")]
        public string UvExpirationType { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonProperty("settlementType")]
        public string SettlementType { get; set; }
    }
}