using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum RequestedDestination
    {
        [EnumMember(Value = "INET")]
        INET,
        [EnumMember(Value = "ECN_ARCA")]
        ECN_ARCA,
        [EnumMember(Value = "CBOE")]
        CBOE,
        [EnumMember(Value = "AMEX")]
        AMEX,
        [EnumMember(Value = "PHLX")]
        PHLX,
        [EnumMember(Value = "ISE")]
        ISE,
        [EnumMember(Value = "BOX")]
        BOX,
        [EnumMember(Value = "NYSE")]
        NYSE,
        [EnumMember(Value = "NASDAQ")]
        NASDAQ,
        [EnumMember(Value = "BATS")]
        BATS,
        [EnumMember(Value = "C2")]
        C2,
        [EnumMember(Value = "AUTO")]
        AUTO,
    }
}