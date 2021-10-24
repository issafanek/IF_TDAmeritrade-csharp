using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum LinkBasis
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL,
        [EnumMember(Value = "BASE")]
        BASE,
        [EnumMember(Value = "TRIGGER")]
        TRIGGER,
        [EnumMember(Value = "LAST")]
        LAST,
        [EnumMember(Value = "BID")]
        BID,
        [EnumMember(Value = "ASK")]
        ASK,
        [EnumMember(Value = "ASK_BID")]
        ASK_BID,
        [EnumMember(Value = "MARK")]
        MARK,
        [EnumMember(Value = "AVERAGE")]
        AVERAGE,
    }
}