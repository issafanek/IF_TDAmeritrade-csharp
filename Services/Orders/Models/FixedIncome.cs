using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public class FixedIncome : Instrument
    {
        [JsonProperty("assetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override AssetType AssetType{ get {return AssetType.FIXED_INCOME;} }

        [JsonProperty("maturityDate")]
        public DateTime MaturityDate { get; set; }

        [JsonProperty("variableRate")]
        public Decimal VariableRate { get; set; }

        [JsonProperty("factor")]
        public Decimal Factor { get; set; }
    }
}