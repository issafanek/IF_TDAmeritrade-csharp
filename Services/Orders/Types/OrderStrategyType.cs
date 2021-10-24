using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum OrderStrategyType
    {
        [EnumMember(Value = "SINGLE")]
        SINGLE,
        [EnumMember(Value = "OCO")]
        OCO,
        [EnumMember(Value = "TRIGGER")]
        TRIGGER,
    }
}