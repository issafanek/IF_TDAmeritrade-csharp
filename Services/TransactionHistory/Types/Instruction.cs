using System.Runtime.Serialization;

namespace TDAmeritrade.Services.TransactionHistory.Types
{
    public enum Instruction
    {
        [EnumMember(Value = "BUY")]
        BUY,
        [EnumMember(Value = "SELL")]
        SELL,
    }
}