using System.Runtime.Serialization;

namespace TDAmeritrade.Services.OptionChains.Types
{
    public enum RangeType
    {
        [EnumMember(Value = "ITM")] //In-the-Money
        ITM,
        [EnumMember(Value = "NTM")] //Near-the-Money
        NTM,
        [EnumMember(Value = "OTM")] //On-the-Money
        OTM,
        [EnumMember(Value = "SAK")] //Strikes Above Market
        SAK,
        [EnumMember(Value = "SBK")] //Strikes Below Market
        SBK,
        [EnumMember(Value = "SNK")] //Strikes Near Market
        SNK,
        [EnumMember(Value = "ALL")]
        ALL,
    }
}