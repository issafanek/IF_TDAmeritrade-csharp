using System.Runtime.Serialization;

namespace TDAmeritrade.Services.MarketHours.Types
{
    public enum MarketType
    {
        [EnumMember(Value = "BOND")]
        BOND,
        [EnumMember(Value = "EQUITY")]
        EQUITY,
        [EnumMember(Value = "ETF")]
        ETF,
        [EnumMember(Value = "FOREX")]
        FOREX,
        [EnumMember(Value = "FUTURE")]
        FUTURE,
        [EnumMember(Value = "FUTURE_OPTION")]
        FUTURE_OPTION,
        [EnumMember(Value = "INDEX")]
        INDEX,
        [EnumMember(Value = "INDICATOR")]
        INDICATOR,
        [EnumMember(Value = "MUTUAL_FUND")]
        MUTUAL_FUND,
        [EnumMember(Value = "OPTION")]
        OPTION,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,
    }
}