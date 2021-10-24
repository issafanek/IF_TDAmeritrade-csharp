using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;
using System.Collections.Generic;

namespace TDAmeritrade.Services.Orders.Models
{
    public class Option : Instrument
    {
        [JsonProperty("assetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override AssetType AssetType { get{return AssetType.OPTION;}}

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OptionType Type { get; set; }

        [JsonProperty("putCall")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OptionPutOrCall PutCall { get; set; }

        [JsonProperty("underlyingSymbol")]
        public string UnderlyingSymbol { get; set; }

        [JsonProperty("optionMultiplier")]
        public Int64 OptionMultiplier { get; set; }

        [JsonProperty("optionDeliverables")]
        public IList<OptionDeliverable> OptionDeliverables { get; set; }
    }
}