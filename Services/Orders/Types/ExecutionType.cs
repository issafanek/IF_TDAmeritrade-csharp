using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum ExecutionType
    {
        [EnumMember(Value = "FILL")]
        FILL,
    }
}