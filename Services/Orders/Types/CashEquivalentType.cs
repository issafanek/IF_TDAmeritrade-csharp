using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum CashEquivalentType
    {
        [EnumMember(Value = "SAVINGS")]
        SAVINGS,
        [EnumMember(Value = "MONEY_MARKET_FUND")]
        MONEY_MARKET_FUND,
    }
}