using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using TDAmeritrade.Services.Orders.Types;
#nullable enable    
namespace TDAmeritrade.Services.Orders.Models
{

    public class Order
    {
        [JsonProperty("session")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Session Session { get; set; }

        [JsonProperty("duration")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Duration Duration { get; set; }

        [JsonProperty("orderType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderType OrderType { get; set; }

        [JsonProperty("cancelTime")]
        public CancelTime? CancelTime { get; set; }

        [JsonProperty("complexOrderStrategyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ComplexOrderStrategyType? ComplexOrderStrategyType { get; set; }

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        [JsonProperty("filledQuantity")]
        public decimal? FilledQuantity { get; set; }

        [JsonProperty("remainingQuantity")]
        public decimal? RemainingQuantity { get; set; }

        [JsonProperty("requestedDestination")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RequestedDestination? RequestedDestination { get; set; }

        [JsonProperty("destinationLinkName")]
        public string? DestinationLinkName { get; set; }

        [JsonProperty("releaseTime")]
        public DateTime? ReleaseTime { get; set; } //format date-time

        [JsonProperty("stopPrice")]
        public decimal? StopPrice { get; set; }

        [JsonProperty("stopPriceLinkBasis")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LinkBasis? StopPriceLinkBasis { get; set; }

        [JsonProperty("stopPriceLinkType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LinkType? StopPriceLinkType { get; set; }

        [JsonProperty("stopPriceOffset")]
        public decimal? StopPriceOffset { get; set; }

        [JsonProperty("stopType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StopType? StopType { get; set; }

        [JsonProperty("priceLinkBasis")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LinkBasis? PriceLinkBasis { get; set; }

        [JsonProperty("priceLinkType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LinkType? PriceLinkType { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("taxLotMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TaxLotMethod? TaxLotMethod { get; set; }

        [JsonProperty("orderLegCollection")]
        public IList<OrderLeg>? OrderLegCollection { get; set; }

        [JsonProperty("activationPrice")]
        public decimal? ActivationPrice { get; set; }

        [JsonProperty("specialInstruction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SpecialInstruction? SpecialInstruction { get; set; }

        [JsonProperty("orderStrategyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderStrategyType OrderStrategyType { get; set; }

        [JsonProperty("orderId")]
        public Int64? OrderId { get; set; }

        [JsonProperty("cancelable")]
        public bool? Cancelable { get; set; }

        [JsonProperty("editable")]
        public bool? Editable { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Status? Status { get; set; }

        [JsonProperty("enteredTime")]
        public DateTime? EnteredTime { get; set; } //format: date-time

        [JsonProperty("closeTime")]
        public DateTime? CloseTime { get; set; } //format: date-time

        [JsonProperty("tag")]
        public string? Tag { get; set; }
        
        [JsonProperty("accountId")]
        public Int64? AccountId { get; set; }

        [JsonProperty("orderActivityCollection")]
        public IList<OrderActivity>? OrderActivityCollection { get; set; }

        [JsonProperty("replacingOrderCollection")]
        public IList<Order>? ReplacingOrderCollection { get; set; }

        [JsonProperty("childOrderStrategies")]
        public IList<Order>? ChildOrderStrategies { get; set; }

        [JsonProperty("statusDescription")]
        public string? StatusDescription { get; set; }
    }

    public class CancelTime
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("shortFormat")]
        public bool ShortFormat { get; set; } = false;
    }

    // public partial class ChildOrderStrategy
    // {
    // }
}