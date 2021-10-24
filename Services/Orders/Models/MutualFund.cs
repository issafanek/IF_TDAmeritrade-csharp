using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public class MutualFund : Instrument
    {
        [JsonProperty("assetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override AssetType AssetType{ get {return AssetType.MUTUAL_FUND;} }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MutualFundType Type { get; set; }
    }
}