using System.Runtime.Serialization;

namespace TDAmeritrade.Services.OptionChains.Types
{
    public enum PutOrCall
    {
        [EnumMember(Value = "PUT")]
        PUT,
        [EnumMember(Value = "CALL")]
        CALL,
    }
}