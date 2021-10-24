using System.Runtime.Serialization;

namespace TDAmeritrade.Services.TransactionHistory.Types
{
    public enum PutCall
    {
        [EnumMember(Value = "PUT")]
        PUT,
        [EnumMember(Value = "CALL")]
        CALL,
    }
}