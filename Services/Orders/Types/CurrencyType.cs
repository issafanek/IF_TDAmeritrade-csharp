using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum CurrencyType
    {
        [EnumMember(Value = "USD")]
        USD,
        [EnumMember(Value = "CAD")]
        CAD,
        [EnumMember(Value = "EUR")]
        EUR,
        [EnumMember(Value = "JPY")]
        JPY,
    }
}