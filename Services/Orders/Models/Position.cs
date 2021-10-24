using System;
using Newtonsoft.Json;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders.Models
{
    public partial class Position
    {
        [JsonProperty("shortQuantity")]
        public decimal ShortQuantity { get; set; }

        [JsonProperty("averagePrice")]
        public decimal AveragePrice { get; set; }

        [JsonProperty("currentDayProfitLoss")]
        public decimal CurrentDayProfitLoss { get; set; }

        [JsonProperty("currentDayProfitLossPercentage")]
        public decimal CurrentDayProfitLossPercentage { get; set; }

        [JsonProperty("longQuantity")]
        public decimal LongQuantity { get; set; }

        [JsonProperty("settledLongQuantity")]
        public decimal SettledLongQuantity { get; set; }

        [JsonProperty("settledShortQuantity")]
        public decimal SettledShortQuantity { get; set; }

        [JsonProperty("agedQuantity")]
        public decimal AgedQuantity { get; set; }

        [JsonProperty("instrument")]
        public Instrument Instrument { get; set; }

        [JsonProperty("marketValue")]
        public decimal MarketValue { get; set; }
    }
}