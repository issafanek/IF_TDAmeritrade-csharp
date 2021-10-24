using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum TaxLotMethod
    {
        [EnumMember(Value = "FIFO")]
        FIFO,
        [EnumMember(Value = "LIFO")]
        LIFO,
        [EnumMember(Value = "HIGH_COST")]
        HIGH_COST,
        [EnumMember(Value = "LOW_COST")]
        LOW_COST,
        [EnumMember(Value = "AVERAGE_COST")]
        AVERAGE_COST,
        [EnumMember(Value = "SPECIFIC_LOT")]
        SPECIFIC_LOT,
    }
}