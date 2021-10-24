using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum OrderType
    {
        [EnumMember(Value = "MARKET")]
        MARKET,
        [EnumMember(Value = "LIMIT")]
        LIMIT,
        [EnumMember(Value = "STOP")]
        STOP,
        [EnumMember(Value = "STOP_LIMIT")]
        STOP_LIMIT,
        [EnumMember(Value = "TRAILING_STOP")]
        TRAILING_STOP,
        [EnumMember(Value = "MARKET_ON_CLOSE")]
        MARKET_ON_CLOSE,
        [EnumMember(Value = "EXERCISE")]
        EXERCISE,
        [EnumMember(Value = "TRAILING_STOP_LIMIT")]
        TRAILING_STOP_LIMIT,
        [EnumMember(Value = "NET_DEBIT")]
        NET_DEBIT,
        [EnumMember(Value = "NET_CREDIT")]
        NET_CREDIT,
        [EnumMember(Value = "NET_ZERO")]
        NET_ZERO,
    }
}