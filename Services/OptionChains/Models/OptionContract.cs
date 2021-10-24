using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.OptionChains.Types;
using TDAmeritrade.Shared.Utilities.Extensions;
    
namespace TDAmeritrade.Services.OptionChains.Models
{    public partial class OptionContract
    {
        [JsonProperty("putCall")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PutOrCall PutCall { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exchangeName")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ExchangeName ExchangeName { get; set; }

        [JsonProperty("bid")]
        public double Bid { get; set; }

        [JsonProperty("ask")]
        public double Ask { get; set; }

        [JsonProperty("last")]
        public double Last { get; set; }

        [JsonProperty("mark")]
        public double Mark { get; set; }

        [JsonProperty("bidSize")]
        public Int64 BidSize { get; set; }

        [JsonProperty("askSize")]
        public Int64 AskSize { get; set; }

        [JsonProperty("bidAskSize")]
        public string BidAskSize { get; set; }

        [JsonProperty("lastSize")]
        public Int64 LastSize { get; set; }

        [JsonProperty("highPrice")]
        public double HighPrice { get; set; }

        [JsonProperty("lowPrice")]
        public double LowPrice { get; set; }

        [JsonProperty("openPrice")]
        public double OpenPrice { get; set; }

        [JsonProperty("closePrice")]
        public double ClosePrice { get; set; }

        [JsonProperty("totalVolume")]
        public Int64 TotalVolume { get; set; }

        //[JsonProperty("tradeDate")]
        //public DateTime? TradeDate { get; set; }

        [JsonProperty("tradeTimeInLong")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime TradeTime { get; set; }

        [JsonProperty("quoteTimeInLong")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime QuoteTime { get; set; }

        [JsonProperty("netChange")]
        public double NetChange { get; set; }

        [JsonProperty("volatility")]
        public double Volatility { get; set; }

        [JsonProperty("delta")]
        public double Delta { get; set; }

        [JsonProperty("gamma")]
        public double Gamma { get; set; }

        [JsonProperty("theta")]
        public double Theta { get; set; }

        [JsonProperty("vega")]
        public double Vega { get; set; }

        [JsonProperty("rho")]
        public double Rho { get; set; }

        [JsonProperty("openInterest")]
        public double OpenInterest { get; set; }

        [JsonProperty("timeValue")]
        public double TimeValue { get; set; }

        [JsonProperty("theoreticalOptionValue")]
        public double TheoreticalOptionValue { get; set; }

        [JsonProperty("theoreticalVolatility")]
        public double TheoreticalVolatility { get; set; }

        //[JsonProperty("optionDeliverablesList")]
        //public object? OptionDeliverablesList { get; set; }

        [JsonProperty("strikePrice")]
        public double StrikePrice { get; set; }

        [JsonProperty("expirationDate")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime ExpirationDate { get; set; }

        [JsonProperty("daysToExpiration")]
        public Int64 DaysToExpiration { get; set; }

        [JsonProperty("expirationType")]
        public string ExpirationType { get; set; }

        [JsonProperty("lastTradingDay")]
        [JsonConverter(typeof(EpochTimestampConverter))]
        public DateTime LastTradingDay { get; set; }

        [JsonProperty("multiplier")]
        public Int64 Multiplier { get; set; }

        [JsonProperty("settlementType")]
        public string SettlementType { get; set; }

        [JsonProperty("deliverableNote")]
        public string DeliverableNote { get; set; }

        //[JsonProperty("isIndexOption")]
        //public bool? IsIndexOption { get; set; }

        [JsonProperty("percentChange")]
        public double PercentChange { get; set; }

        [JsonProperty("markChange")]
        public double MarkChange { get; set; }

        [JsonProperty("markPercentChange")]
        public double MarkPercentChange { get; set; }

        [JsonProperty("nonStandard")]
        public bool NonStandard { get; set; }

        [JsonProperty("mini")]
        public bool Mini { get; set; }

        [JsonProperty("inTheMoney")]
        public bool InTheMoney { get; set; }
    }
}