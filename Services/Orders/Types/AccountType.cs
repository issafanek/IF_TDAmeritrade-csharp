using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum AccountType
    {
        [EnumMember(Value = "CASH")]
        CASH,
        [EnumMember(Value = "MARGIN")]
        MARGIN,
    }
}