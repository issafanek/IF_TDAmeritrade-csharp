using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum LinkType
    {
        [EnumMember(Value = "VALUE")]
        VALUE,
        [EnumMember(Value = "PERCENT")]
        PERCENT,
        [EnumMember(Value = "TICK")]
        TICK,
    }
}