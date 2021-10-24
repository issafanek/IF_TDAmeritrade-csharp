using System.Runtime.Serialization;

namespace TDAmeritrade.Services.OptionChains.Types
{
    public enum ExchangeName
    {
        [EnumMember(Value = "IND")]
        IND,
        [EnumMember(Value = "ASE")]
        ASE,
        [EnumMember(Value = "NYS")]
        NYS,
        [EnumMember(Value = "NAS")]
        NAS,
        [EnumMember(Value = "NAP")]
        NAP,
        [EnumMember(Value = "PAC")]
        PAC,
        [EnumMember(Value = "OPR")]
        OPR,
        [EnumMember(Value = "BATS")]
        BATS,
    }
}