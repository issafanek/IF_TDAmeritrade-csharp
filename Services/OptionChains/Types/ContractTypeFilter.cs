using System.Runtime.Serialization;

namespace TDAmeritrade.Services.OptionChains.Types
{
    public enum ContractTypeFilter
    {
        [EnumMember(Value = "PUT")] //Standard Contracts
        PUT,
        [EnumMember(Value = "CALL")] //Non-Standard Contracts
        CALL,
        [EnumMember(Value = "ALL")]
        ALL,
    }
}