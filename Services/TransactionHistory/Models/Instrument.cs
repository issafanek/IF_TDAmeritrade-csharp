using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using TDAmeritrade.Services.TransactionHistory.Types;
#nullable enable    
namespace TDAmeritrade.Services.TransactionHistory.Models
{

    public class Instrument
    {
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("underlyingSymbol")]
        public string? UnderlyingSymbol { get; set; }

        [JsonProperty("optionExpirationDate")]
        public DateTime? OptionExpirationDate { get; set; }

        [JsonProperty("optionStrikePrice")]
        public decimal? OptionStrikePrice { get; set; }

        [JsonProperty("putCall")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PutCall? PutCall { get; set; }

        [JsonProperty("cusip")]
        public string? Cusip { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("assetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AssetType? AssetType { get; set; }

        [JsonProperty("bondMaturityDate")]
        public DateTime? BondMaturityDate { get; set; }

        [JsonProperty("bondInterestRate")]
        public decimal? BondInterestRate { get; set; }
    }
}