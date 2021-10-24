using System;
using Newtonsoft.Json;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.Quotes.Models
{
    public class Future
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("bidPriceInDouble")]
        public decimal BidPrice{ get; set; }

        [JsonProperty("askPriceInDouble")]
        public decimal AskPrice{ get; set; }

        [JsonProperty("lastPriceInDouble")]
        public decimal LastPrice{ get; set; }

        [JsonProperty("bidId")]
        public string BidId { get; set; }

        [JsonProperty("askId")]
        public string AskId { get; set; }

        [JsonProperty("highPriceInDouble")]
        public decimal HighPrice{ get; set; }

        [JsonProperty("lowPriceInDouble")]
        public decimal LowPrice{ get; set; }

        [JsonProperty("closePriceInDouble")]
        public decimal ClosePrice{ get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastId")]
        public string LastId { get; set; }

        [JsonProperty("openPriceInDouble")]
        public decimal OpenPrice{ get; set; }

        [JsonProperty("changeInDouble")]
        public decimal Change{ get; set; }

        [JsonProperty("futurePercentChange")]
        public decimal FuturePercentChange { get; set; }

        [JsonProperty("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonProperty("securityStatus")]
        public string SecurityStatus { get; set; }

        [JsonProperty("openInterest")]
        public decimal OpenInterest { get; set; }

        [JsonProperty("mark")]
        public decimal Mark { get; set; }

        [JsonProperty("tick")]
        public decimal Tick { get; set; }

        [JsonProperty("tickAmount")]
        public decimal TickAmount { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("futurePriceFormat")]
        public string FuturePriceFormat { get; set; }

        [JsonProperty("futureTradingHours")]
        public string FutureTradingHours { get; set; }

        [JsonProperty("futureIsTradable")]
        public bool FutureIsTradable { get; set; }

        [JsonProperty("futureMultiplier")]
        public decimal FutureMultiplier { get; set; }

        [JsonProperty("futureIsActive")]
        public bool FutureIsActive { get; set; }

        [JsonProperty("futureSettlementPrice")]
        public decimal FutureSettlementPrice { get; set; }

        [JsonProperty("futureActiveSymbol")]
        public string FutureActiveSymbol { get; set; }

        [JsonProperty("futureExpirationDate")]
        public DateTime FutureExpirationDate { get; set; }
    }
}