using System.Runtime.Serialization;

namespace TDAmeritrade.Services.TransactionHistory.Types
{
    public enum TransactionType
    {
        [EnumMember(Value = "TRADE")]
        TRADE,
        [EnumMember(Value = "RECEIVE_AND_DELIVER")]
        RECEIVE_AND_DELIVER,
        [EnumMember(Value = "DIVIDEND_OR_INTEREST")]
        DIVIDEND_OR_INTEREST,
        [EnumMember(Value = "ACH_RECEIPT")]
        ACH_RECEIPT,
        [EnumMember(Value = "ACH_DISBURSEMENT")]
        ACH_DISBURSEMENT,
        [EnumMember(Value = "CASH_RECEIPT")]
        CASH_RECEIPT,
        [EnumMember(Value = "CASH_DISBURSEMENT")]
        CASH_DISBURSEMENT,
        [EnumMember(Value = "ELECTRONIC_FUND")]
        ELECTRONIC_FUND,
        [EnumMember(Value = "WIRE_OUT")]
        WIRE_OUT,
        [EnumMember(Value = "WIRE_IN")]
        WIRE_IN,
        [EnumMember(Value = "JOURNAL")]
        JOURNAL,
        [EnumMember(Value = "MEMORANDUM")]
        MEMORANDUM,
        [EnumMember(Value = "MARGIN_CALL")]
        MARGIN_CALL,
        [EnumMember(Value = "MONEY_MARKET")]
        MONEY_MARKET,
        [EnumMember(Value = "SMA_ADJUSTMENT")]
        SMA_ADJUSTMENT,
        [EnumMember(Value = "ALL")]
        ALL,

    }
}