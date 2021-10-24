#nullable enable 
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public partial class Instrument
    {
        [JsonProperty("assetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual AssetType AssetType{ get; set; }

        [JsonProperty("cusip")]
        public virtual string? Cusip { get; set; }

        [JsonProperty("symbol")]
        public virtual string Symbol { get; set; }

        [JsonProperty("description")]
        public virtual string? Description { get; set; }
    }
}
