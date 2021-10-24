using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum Instruction
    {
        [EnumMember(Value = "BUY")]
        BUY,
        [EnumMember(Value = "SELL")]
        SELL,
        [EnumMember(Value = "BUY_TO_COVER")]
        BUY_TO_COVER,
        [EnumMember(Value = "SELL_SHORT")]
        SELL_SHORT,
        [EnumMember(Value = "BUY_TO_OPEN")]
        BUY_TO_OPEN,
        [EnumMember(Value = "BUY_TO_CLOSE")]
        BUY_TO_CLOSE,
        [EnumMember(Value = "SELL_TO_OPEN")]
        SELL_TO_OPEN,
        [EnumMember(Value = "SELL_TO_CLOSE")]
        SELL_TO_CLOSE,
        [EnumMember(Value = "EXCHANGE")]
        EXCHANGE,
    }
}