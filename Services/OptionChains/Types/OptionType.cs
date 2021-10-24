using System.Runtime.Serialization;

namespace TDAmeritrade.Services.OptionChains.Types
{
    public enum OptionType
    {
        [EnumMember(Value = "S")] //Standard Contracts
        S,
        [EnumMember(Value = "NS")] //Non-Standard Contracts
        NS,
        [EnumMember(Value = "ALL")]
        ALL,
    }
}