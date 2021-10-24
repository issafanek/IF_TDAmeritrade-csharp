using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Orders.Types
{
    public enum Status
    {
        [EnumMember(Value = "AWAITING_PARENT_ORDER")]
        AWAITING_PARENT_ORDER,
        [EnumMember(Value = "AWAITING_CONDITION")]
        AWAITING_CONDITION,
        [EnumMember(Value = "AWAITING_MANUAL_REVIEW")]
        AWAITING_MANUAL_REVIEW,
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED,
        [EnumMember(Value = "AWAITING_UR_OUT")]
        AWAITING_UR_OUT,
        [EnumMember(Value = "PENDING_ACTIVATION")]
        PENDING_ACTIVATION,
        [EnumMember(Value = "QUEUED")]
        QUEUED,
        [EnumMember(Value = "WORKING")]
        WORKING,
        [EnumMember(Value = "REJECTED")]
        REJECTED,
        [EnumMember(Value = "PENDING_CANCEL")]
        PENDING_CANCEL,
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        [EnumMember(Value = "PENDING_REPLACE")]
        PENDING_REPLACE,
        [EnumMember(Value = "REPLACED")]
        REPLACED,
        [EnumMember(Value = "FILLED")]
        FILLED,
        [EnumMember(Value = "EXPIRED")]
        EXPIRED,
        [EnumMember(Value = "NOT_DEFINED")]
        NOT_DEFINED,
    }
}