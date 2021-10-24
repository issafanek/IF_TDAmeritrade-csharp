using System.Runtime.Serialization;

namespace TDAmeritrade.Services.PriceHistory.Types
{
    public enum PeriodType
    {
        [EnumMember(Value = "day")]
        day,
        [EnumMember(Value = "month")]
        month,
        [EnumMember(Value = "year")]
        year,
        [EnumMember(Value = "ytd")]
        ytd,
    }
}