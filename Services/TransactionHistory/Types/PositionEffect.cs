using System.Runtime.Serialization;

namespace TDAmeritrade.Services.TransactionHistory.Types
{
    public enum PositionEffect
    {
        [EnumMember(Value = "OPENING")]
        OPENING,
        [EnumMember(Value = "CLOSING")]
        CLOSING,
        [EnumMember(Value = "AUTOMATIC")]
        AUTOMATIC,
    }
}