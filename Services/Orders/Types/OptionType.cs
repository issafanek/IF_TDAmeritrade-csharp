using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum OptionType
    {
        [EnumMember(Value = "VANILLA")]
        VANILLA,
        [EnumMember(Value = "BINARY")]
        BINARY,
        [EnumMember(Value = "BARRIER")]
        BARRIER,
    }
}