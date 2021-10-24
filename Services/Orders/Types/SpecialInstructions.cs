using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum SpecialInstruction
    {
        [EnumMember(Value = "ALL_OR_NONE")]
        ALL_OR_NONE,
        [EnumMember(Value = "DO_NOT_REDUCE")]
        DO_NOT_REDUCE,
        [EnumMember(Value = "ALL_OR_NONE_DO_NOT_REDUCE")]
        ALL_OR_NONE_DO_NOT_REDUCE,
    }
}