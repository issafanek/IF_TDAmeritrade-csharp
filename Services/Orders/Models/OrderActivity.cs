using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public class OrderActivity
    {
        [JsonProperty("ActivityType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual ActivityType DeliverableUnits { get; set; }
    }
}