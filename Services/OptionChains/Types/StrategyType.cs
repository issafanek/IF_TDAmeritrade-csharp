using System.Runtime.Serialization;

namespace TDAmeritrade.Services.OptionChains.Types
{
    public enum StrategyType
    {
        [EnumMember(Value = "SINGLE")]
        SINGLE,
        [EnumMember(Value = "ANALYTICAL")] //allows use of the volatility, underlyingPrice, interestRate, and daysToExpiration params to calculate theoretical values
        ANALYTICAL,
        [EnumMember(Value = "COVERED")]
        COVERED,
        [EnumMember(Value = "VERTICAL")]
        VERTICAL,
        [EnumMember(Value = "CALENDAR")]
        CALENDAR,
        [EnumMember(Value = "STRANGLE")]
        STRANGLE,
        [EnumMember(Value = "STRADDLE")]
        STRADDLE,
        [EnumMember(Value = "BUTTERFLY")]
        BUTTERFLY,
        [EnumMember(Value = "CONDOR")]
        CONDOR,
        [EnumMember(Value = "DIAGONAL")]
        DIAGONAL,
        [EnumMember(Value = "COLLAR")]
        COLLAR,
        [EnumMember(Value = "ROLL")]
        ROLL,
    }
}