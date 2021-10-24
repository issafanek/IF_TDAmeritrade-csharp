using System.Runtime.Serialization;

namespace TDAmeritrade.Services.TransactionHistory.Types
{
    public enum AchStatus
    {
        [EnumMember(Value = "Approved")]
        APPROVED,
        [EnumMember(Value = "Rejected")]
        REJECTED,
        [EnumMember(Value = "Cancel")]
        CANCEL,
        [EnumMember(Value = "Error")]
        ERROR,
    }
}