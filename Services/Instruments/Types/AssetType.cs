using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Instruments.Types
{
    //"assetType": "'EQUITY' or 'ETF' or 'FOREX' or 'FUTURE' or 'FUTURE_OPTION' or 'INDEX' or 'INDICATOR' or 'MUTUAL_FUND' or 'OPTION' or 'UNKNOWN'"
    public enum AssetType
    {
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
        [EnumMember(Value = "UKNOWN")]
        UNKNOWN,
        [EnumMember(Value = "BOND")]
        BOND,
    }
}