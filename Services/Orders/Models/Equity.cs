using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public class Equity : Instrument
    {
        [JsonProperty("assetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override AssetType AssetType{ get {return AssetType.EQUITY;} }
    }
}