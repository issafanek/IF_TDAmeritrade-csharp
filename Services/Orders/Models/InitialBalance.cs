using Newtonsoft.Json;

namespace TDAmeritrade.Services.Orders.Models
{
    public partial class InitialBalances
    {
        [JsonProperty("accruedInterest")]
        public decimal? AccruedInterest { get; set; }

        [JsonProperty("cashAvailableForTrading")]
        public decimal? CashAvailableForTrading { get; set; }

        [JsonProperty("cashAvailableForWithdrawal")]
        public decimal? CashAvailableForWithdrawal { get; set; }

        [JsonProperty("cashBalance")]
        public decimal? CashBalance { get; set; }

        [JsonProperty("bondValue")]
        public decimal? BondValue { get; set; }

        [JsonProperty("cashReceipts")]
        public decimal? CashReceipts { get; set; }

        [JsonProperty("liquidationValue")]
        public decimal? LiquidationValue { get; set; }

        [JsonProperty("longOptionMarketValue")]
        public decimal? LongOptionMarketValue { get; set; }

        [JsonProperty("longStockValue")]
        public decimal? LongStockValue { get; set; }

        [JsonProperty("moneyMarketFund")]
        public decimal? MoneyMarketFund { get; set; }

        [JsonProperty("mutualFundValue")]
        public decimal? MutualFundValue { get; set; }

        [JsonProperty("shortOptionMarketValue")]
        public decimal? ShortOptionMarketValue { get; set; }

        [JsonProperty("shortStockValue")]
        public decimal? ShortStockValue { get; set; }

        [JsonProperty("isInCall")]
        public bool IsInCall { get; set; }

        [JsonProperty("unsettledCash")]
        public decimal? UnsettledCash { get; set; }

        [JsonProperty("cashDebitCallValue")]
        public decimal? CashDebitCallValue { get; set; }

        [JsonProperty("pendingDeposits")]
        public decimal? PendingDeposits { get; set; }

        [JsonProperty("accountValue")]
        public decimal? AccountValue { get; set; }

        [JsonProperty("availableFundsNonMarginableTrade")]
        public decimal? AvailableFundsNonMarginableTrade { get; set; }

        [JsonProperty("buyingPower")]
        public decimal? BuyingPower { get; set; }

        [JsonProperty("dayTradingBuyingPower")]
        public decimal? DayTradingBuyingPower { get; set; }

        [JsonProperty("dayTradingBuyingPowerCall")]
        public decimal? DayTradingBuyingPowerCall { get; set; }

        [JsonProperty("dayTradingEquityCall")]
        public decimal? DayTradingEquityCall { get; set; }

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

        [JsonProperty("margin")]
        public decimal? Margin { get; set; }

        [JsonProperty("marginEquity")]
        public decimal? MarginEquity { get; set; }

        [JsonProperty("regTCall")]
        public decimal? RegTCall { get; set; }

        [JsonProperty("shortMarginValue")]
        public decimal? ShortMarginValue { get; set; }

        [JsonProperty("totalCash")]
        public decimal? TotalCash { get; set; }


        [JsonProperty("marginBalance")]
        public decimal? MarginBalance { get; set; }

        [JsonProperty("shortBalance")]
        public decimal? ShortBalance { get; set; }
    }
}