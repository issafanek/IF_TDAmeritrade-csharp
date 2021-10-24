using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using TDAmeritrade.Services.TransactionHistory.Types;
#nullable enable    
namespace TDAmeritrade.Services.TransactionHistory.Models
{

    public class Fees
    {
        [JsonProperty("rFee")]
        public decimal? RFee { get; set; }

        [JsonProperty("additionalFee")]
        public decimal? AdditionalFee { get; set; }

        [JsonProperty("cdscFee")]
        public decimal? CdscFee { get; set; }

        [JsonProperty("regFee")]
        public decimal? RegFee { get; set; }

        [JsonProperty("otherCharges")]
        public decimal? OtherCharges { get; set; }

        [JsonProperty("commission")]
        public decimal? Commission { get; set; }

        [JsonProperty("optRegFee")]
        public decimal? OptRegFee { get; set; }

        [JsonProperty("secFee")]
        public decimal? SecFee { get; set; }
    }
}