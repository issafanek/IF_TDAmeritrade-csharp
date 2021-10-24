using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public class Execution : OrderActivity
    {
        // [JsonProperty("ActivityType")]
        // public virtual ActivityType DeliverableUnits { get; set; }

        [JsonProperty("executionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ExecutionType ExecutionType { get; set; }

        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty("orderRemainingQuantity")]
        public decimal OrderRemainingQuantity { get; set; }

        [JsonProperty("executionLegs")]
        public IList<ExecutionLeg> ExecutionLegs { get; set; }
    }
}