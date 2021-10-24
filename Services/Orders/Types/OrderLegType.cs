using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum OrderLegType
    {
        [EnumMember(Value = "EQUITY")]
        EQUITY,
        [EnumMember(Value = "OPTION")]
        OPTION,
        [EnumMember(Value = "INDEX")]
        INDEX,
        [EnumMember(Value = "MUTUAL_FUND")]
        MUTUAL_FUND,
        [EnumMember(Value = "CASH_EQUIVALENT")]
        CASH_EQUIVALENT,
        [EnumMember(Value = "FIXED_INCOME")]
        FIXED_INCOME,
        [EnumMember(Value = "CURRENCY")]
        CURRENCY,
    }
}