using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum ComplexOrderStrategyType
    {
        [EnumMember(Value = "NONE")]
        NONE,
        [EnumMember(Value = "COVERED")]
        COVERED,
        [EnumMember(Value = "VERTICAL")]
        VERTICAL,
        [EnumMember(Value = "BACK_RATIO")]
        BACK_RATIO,
        [EnumMember(Value = "CALENDAR")]
        CALENDAR,
        [EnumMember(Value = "DIAGONAL")]
        DIAGONAL,
        [EnumMember(Value = "STRADDLE")]
        STRADDLE,
        [EnumMember(Value = "STRANGLE")]
        STRANGLE,
        [EnumMember(Value = "COLLAR_SYNTHETIC")]
        COLLAR_SYNTHETIC,
        [EnumMember(Value = "BUTTERFLY")]
        BUTTERFLY,
        [EnumMember(Value = "CONDOR")]
        CONDOR,
        [EnumMember(Value = "IRON_CONDOR")]
        IRON_CONDOR,
        [EnumMember(Value = "VERTICAL_ROLL")]
        VERTICAL_ROLL,
        [EnumMember(Value = "COLLAR_WITH_STOCK")]
        COLLAR_WITH_STOCK,
        [EnumMember(Value = "DOUBLE_DIAGONAL")]
        DOUBLE_DIAGONAL,
        [EnumMember(Value = "UNBALANCED_BUTTERFLY")]
        UNBALANCED_BUTTERFLY,
        [EnumMember(Value = "UNBALANCED_CONDOR")]
        UNBALANCED_CONDOR,
        [EnumMember(Value = "UNBALANCED_IRON_CONDOR")]
        UNBALANCED_IRON_CONDOR,
        [EnumMember(Value = "UNBALANCED_VERTICAL_ROLL")]
        UNBALANCED_VERTICAL_ROLL,
        [EnumMember(Value = "CUSTOM")]
        CUSTOM,
    }
}