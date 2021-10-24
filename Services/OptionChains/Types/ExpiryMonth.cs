using System.Runtime.Serialization;
namespace TDAmeritrade.Services.OptionChains.Types
{
    public enum ExpiryMonth
    {
        [EnumMember(Value = "ALL")]
        ALL,
        [EnumMember(Value = "JAN")]
        JAN,
        [EnumMember(Value = "FEB")]
        FEB,
        [EnumMember(Value = "MAR")]
        MAR,
        [EnumMember(Value = "APR")]
        APR,
        [EnumMember(Value = "MAY")]
        MAY,
        [EnumMember(Value = "JUN")]
        JUN,
        [EnumMember(Value = "JUL")]
        JUL,
        [EnumMember(Value = "AUG")]
        AUG,
        [EnumMember(Value = "SEP")]
        SEP,
        [EnumMember(Value = "OCT")]
        OCT,
        [EnumMember(Value = "NOV")]
        NOV,
        [EnumMember(Value = "DEC")]
        DEC,
    }
}