using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public class OptionDeliverable
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("deliverableUnits")]
        public decimal DeliverableUnits { get; set; }

        [JsonProperty("currencyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CurrencyType CurrencyType { get; set; }

        [JsonProperty("assetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AssetType AssetType { get; set; }
    }
}