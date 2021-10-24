using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public class OrderLeg
    {
        [JsonProperty("orderLegType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderLegType? OrderLegType { get; set; }

        [JsonProperty("legId")]
        public Int64? LegId { get; set; }

        [JsonProperty("instrument")]
        public Instrument Instrument { get; set; }

        [JsonProperty("instruction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Instruction Instruction { get; set; }

        [JsonProperty("positionEffect")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PositionEffect? PositionEffect { get; set; }

        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty("quantityType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public QuantityType? QuantityType { get; set; }
    }
}