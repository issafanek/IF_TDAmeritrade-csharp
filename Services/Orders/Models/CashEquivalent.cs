using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public class CashEquivalent : Instrument
    {
        [JsonProperty("assetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override AssetType AssetType{ get {return AssetType.CASH_EQUIVALENT;} }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CashEquivalentType Type { get; set; }
    }
}