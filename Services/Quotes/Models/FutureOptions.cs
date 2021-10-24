using System;
using Newtonsoft.Json;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.Quotes.Models
{
    public class FutureOptions
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("bidPriceInDouble")]
        public decimal BidPrice { get; set; }

        [JsonProperty("askPriceInDouble")]
        public decimal AskPrice { get; set; }

        [JsonProperty("lastPriceInDouble")]
        public decimal LastPrice { get; set; }

        [JsonProperty("highPriceInDouble")]
        public decimal HighPrice { get; set; }

        [JsonProperty("lowPriceInDouble")]
        public decimal LowPrice{ get; set; }

        [JsonProperty("closePriceInDouble")]
        public decimal ClosePrice{ get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("openPriceInDouble")]
        public decimal OpenPrice{ get; set; }

        [JsonProperty("netChangeInDouble")]
        public decimal NetChange{ get; set; }

        [JsonProperty("openInterest")]
        public decimal OpenInterest { get; set; }

        [JsonProperty("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonProperty("securityStatus")]
        public string SecurityStatus { get; set; }

        [JsonProperty("volatility")]
        public decimal Volatility { get; set; }

        [JsonProperty("moneyIntrinsicValueInDouble")]
        public decimal MoneyIntrinsicValue{ get; set; }

        [JsonProperty("multiplierInDouble")]
        public decimal Multiplier{ get; set; }

        [JsonProperty("digits")]
        public Int64 Digits { get; set; }

        [JsonProperty("strikePriceInDouble")]
        public decimal StrikePrice{ get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("underlying")]
        public string Underlying { get; set; }

        [JsonProperty("timeValueInDouble")]
        public decimal TimeValue{ get; set; }

        [JsonProperty("deltaInDouble")]
        public decimal Delta{ get; set; }

        [JsonProperty("gammaInDouble")]
        public decimal Gamma{ get; set; }

        [JsonProperty("thetaInDouble")]
        public decimal Theta{ get; set; }

        [JsonProperty("vegaInDouble")]
        public decimal Vega{ get; set; }

        [JsonProperty("rhoInDouble")]
        public decimal Rho{ get; set; }

        [JsonProperty("mark")]
        public decimal Mark { get; set; }

        [JsonProperty("tick")]
        public decimal Tick { get; set; }

        [JsonProperty("tickAmount")]
        public decimal TickAmount { get; set; }

        [JsonProperty("futureIsTradable")]
        public bool FutureIsTradable { get; set; }

        [JsonProperty("futureTradingHours")]
        public string FutureTradingHours { get; set; }

        [JsonProperty("futurePercentChange")]
        public decimal FuturePercentChange { get; set; }

        [JsonProperty("futureIsActive")]
        public bool FutureIsActive { get; set; }

        [JsonProperty("futureExpirationDate")]
        public DateTime FutureExpirationDate { get; set; }

        [JsonProperty("expirationType")]
        public string ExpirationType { get; set; }

        [JsonProperty("exerciseType")]
        public string ExerciseType { get; set; }

        [JsonProperty("inTheMoney")]
        public bool InTheMoney { get; set; }
    }
}