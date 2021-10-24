using Newtonsoft.Json;
namespace TDAmeritrade.Services.Orders.Models
{
    public class CurrentOrProjectedBalances
    {
        [JsonProperty("accruedInterest")]
        public decimal? AccruedInterest { get; set; }

        [JsonProperty("cashBalance")]
        public decimal? CashBalance { get; set; }

        [JsonProperty("cashReceipts")]
        public decimal? CashReceipts { get; set; }

        [JsonProperty("longOptionMarketValue")]
        public decimal? LongOptionMarketValue { get; set; }

        [JsonProperty("liquidationValue")]
        public decimal? LiquidationValue { get; set; }

        [JsonProperty("longMarketValue")]
        public decimal? LongMarketValue { get; set; }

        [JsonProperty("moneyMarketFund")]
        public decimal? MoneyMarketFund { get; set; }

        [JsonProperty("savings")]
        public decimal? Savings { get; set; }

        [JsonProperty("shortMarketValue")]
        public decimal? ShortMarketValue { get; set; }

        [JsonProperty("pendingDeposits")]
        public decimal? PendingDeposits { get; set; }

        [JsonProperty("cashAvailableForTrading")]
        public decimal? CashAvailableForTrading { get; set; }

        [JsonProperty("cashAvailableForWithdrawal")]
        public decimal? CashAvailableForWithdrawal { get; set; }

        [JsonProperty("cashCall")]
        public decimal? CashCall { get; set; }

        [JsonProperty("longNonMarginableMarketValue")]
        public decimal? LongNonMarginableMarketValue { get; set; }

        [JsonProperty("totalCash")]
        public decimal? TotalCash { get; set; }

        [JsonProperty("shortOptionMarketValue")]
        public decimal? ShortOptionMarketValue { get; set; }

        [JsonProperty("mutualFundValue")]
        public decimal? MutualFundValue { get; set; }

        [JsonProperty("bondValue")]
        public decimal? BondValue { get; set; }

        [JsonProperty("cashDebitCallValue")]
        public decimal? CashDebitCallValue { get; set; }

        [JsonProperty("unsettledCash")]
        public decimal? UnsettledCash { get; set; }

        [JsonProperty("availableFunds")]
        public decimal? AvailableFunds { get; set; }

        [JsonProperty("availableFundsNonMarginableTrade")]
        public decimal? AvailableFundsNonMarginableTrade { get; set; }

        [JsonProperty("buyingPower")]
        public decimal? BuyingPower { get; set; }

        [JsonProperty("buyingPowerNonMarginableTrade")]
        public decimal? BuyingPowerNonMarginableTrade { get; set; }

        [JsonProperty("dayTradingBuyingPower")]
        public decimal? DayTradingBuyingPower { get; set; }

        [JsonProperty("dayTradingBuyingPowerCall")]
        public decimal? DayTradingBuyingPowerCall { get; set; }

        [JsonProperty("equity")]
        public decimal? Equity { get; set; }

        [JsonProperty("equityPercentage")]
        public decimal? EquityPercentage { get; set; }

        [JsonProperty("longMarginValue")]
        public decimal? LongMarginValue { get; set; }

        [JsonProperty("maintenanceCall")]
        public decimal? MaintenanceCall { get; set; }

        [JsonProperty("maintenanceRequirement")]
        public decimal? MaintenanceRequirement { get; set; }

        [JsonProperty("marginBalance")]
        public decimal? MarginBalance { get; set; }

        [JsonProperty("regTCall")]
        public decimal? RegTCall { get; set; }

        [JsonProperty("shortBalance")]
        public decimal? ShortBalance { get; set; }

        [JsonProperty("shortMarginValue")]
        public decimal? ShortMarginValue { get; set; }

        [JsonProperty("sma")]
        public decimal? Sma { get; set; }

        [JsonProperty("isInCall")]
        public bool IsInCall { get; set; }

        [JsonProperty("stockBuyingPower")]
        public decimal? StockBuyingPower { get; set; }

        [JsonProperty("optionBuyingPower")]
        public decimal? OptionBuyingPower { get; set; }
    }
}