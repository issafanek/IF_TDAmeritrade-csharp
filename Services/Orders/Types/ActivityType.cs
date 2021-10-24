using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum ActivityType
    {
        [EnumMember(Value = "EXECUTION")]
        EXECUTION,
        [EnumMember(Value = "ORDER_ACTION")]
        ORDER_ACTION,
    }
}