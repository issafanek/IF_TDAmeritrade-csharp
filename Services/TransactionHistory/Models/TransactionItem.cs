using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using TDAmeritrade.Services.TransactionHistory.Types;
#nullable enable    
namespace TDAmeritrade.Services.TransactionHistory.Models
{

    public class TransactionItem
    {
        [JsonProperty("accountId")]
        public Int64? AccountId { get; set; }

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("cost")]
        public decimal? Cost { get; set; }

        [JsonProperty("parentOrderKey")]
        public Int64? ParentOrderKey { get; set; }

        [JsonProperty("parentChildIndicator")]
        public string? ParentChildIndicator { get; set; }

        [JsonProperty("instruction")]
        public Instruction? Instruction { get; set; }

        [JsonProperty("positionEffect")]
        public PositionEffect? PositionEffect { get; set; }

        [JsonProperty("instrument")]
        public Instrument? Instrument { get; set; }
    }
}