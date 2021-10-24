using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum OptionPutOrCall
    {
        [EnumMember(Value = "PUT")]
        PUT,
        [EnumMember(Value = "CALL")]
        CALL,
    }
}