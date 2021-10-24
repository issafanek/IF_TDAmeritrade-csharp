using System.Runtime.Serialization;

namespace TDAmeritrade.Services.MarketHours.Types
{
    public enum SupportedMarketType
    {
        [EnumMember(Value = "EQUITY")]
        EQUITY,
        [EnumMember(Value = "OPTION")]
        OPTION,
    }
}