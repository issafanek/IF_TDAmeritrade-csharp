using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum MutualFundType
    {
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE,
        [EnumMember(Value = "OPEN_END_NON_TAXABLE")]
        OPEN_END_NON_TAXABLE,
        [EnumMember(Value = "OPEN_END_TAXABLE")]
        OPEN_END_TAXABLE,
        [EnumMember(Value = "NO_LOAD_NON_TAXABLE")]
        NO_LOAD_NON_TAXABLE,
        [EnumMember(Value = "NO_LOAD_TAXABLE")]
        NO_LOAD_TAXABLE,
    }
}