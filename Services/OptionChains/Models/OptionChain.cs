using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.OptionChains.Types;
using TDAmeritrade.Shared.Utilities.Extensions;
    
namespace TDAmeritrade.Services.OptionChains.Models
{    public partial class OptionChain
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("underlying")]
        public UnderlyingInstrument Underlying { get; set; }

        [JsonProperty("strategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StrategyType Strategy { get; set; }

        [JsonProperty("interval")]
        public decimal Interval { get; set; }

        [JsonProperty("isDelayed")]
        public bool IsDelayed { get; set; }

        [JsonProperty("isIndex")]
        public bool IsIndex { get; set; }

        [JsonProperty("interestRate")]
        public double InterestRate { get; set; }

        [JsonProperty("underlyingPrice")]
        public double UnderlyingPrice { get; set; }

        [JsonProperty("volatility")]
        public decimal Volatility { get; set; }

        [JsonProperty("daysToExpiration")]
        public Int64 DaysToExpiration { get; set; }

        [JsonProperty("numberOfContracts")]
        public Int64 NumberOfContracts { get; set; }

        [JsonProperty("putExpDateMap")]
        public IDictionary<string, IDictionary<string, IList<OptionContract>>> PutExpDateMap { get; set; }

        [JsonProperty("callExpDateMap")]
        public IDictionary<string, IDictionary<string, IList<OptionContract>>> CallExpDateMap { get; set; }
    }
}