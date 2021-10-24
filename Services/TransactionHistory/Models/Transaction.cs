using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using TDAmeritrade.Services.TransactionHistory.Types;
#nullable enable    
namespace TDAmeritrade.Services.TransactionHistory.Models
{

    public class Transaction
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionType? Type { get; set; }

        [JsonProperty("clearingReferenceNumber")]
        public string? ClearingReferenceNumber { get; set; }

        [JsonProperty("subAccount")]
        public string? SubAccount { get; set; }

        [JsonProperty("settlementDate")]
        public DateTime? SettlementDate { get; set; }

        [JsonProperty("orderId")]
        public string? OrderId { get; set; }

        [JsonProperty("sma")]
        public decimal? Sma { get; set; }

        [JsonProperty("requirementReallocationAmount")]
        public decimal? RequirementReallocationAmount { get; set; }

        [JsonProperty("dayTradeBuyingPowerEffect")]
        public decimal? DayTradeBuyingPowerEffect { get; set; }

        [JsonProperty("netAmount")]
        public decimal? NetAmount { get; set; }

        [JsonProperty("transactionDate")]
        public DateTime? TransactionDate { get; set; }

        [JsonProperty("orderDate")]
        public DateTime? OrderDate { get; set; }

        [JsonProperty("transactionSubType")]
        public string? TransactionSubType { get; set; }

        [JsonProperty("transactionId")]
        public Int64? TransactionId { get; set; }

        [JsonProperty("cashBalanceEffectFlag")]
        public bool? CashBalanceEffectFlag { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("achStatus")]
        [JsonConverter(typeof(StringEnumConverter))]

        public AchStatus? AchStatus { get; set; }

        [JsonProperty("accruedInterest")]
        public decimal? AccruedInterest { get; set; }

        [JsonProperty("fees")]
        public Fees? Fees { get; set; }

        [JsonProperty("transactionItem")]
        public TransactionItem? TransactionItem { get; set; }
    }
}