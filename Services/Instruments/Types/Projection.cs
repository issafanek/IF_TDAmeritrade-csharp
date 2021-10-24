using System.Runtime.Serialization;

namespace TDAmeritrade.Services.Instruments.Types
{
    public enum Projection
    {
        [EnumMember(Value = "symbol-search")]
        SYMBOL_SEARCH,
        [EnumMember(Value = "symbol-regex")]
        SYMBOL_REGEX,
        [EnumMember(Value = "desc-search")]
        DESC_SEARCH,
        [EnumMember(Value = "desc-regex")]
        DESC_REGEX,
        [EnumMember(Value = "fundamental")]
        FUNDAMENTAL,
    }

    static public class ProjectionToString
    {
        static public string Value(Projection p)
        {
            if(p == Projection.SYMBOL_SEARCH) return "symbol-search";
            if(p == Projection.SYMBOL_REGEX) return "symbol-regex";
            if(p == Projection.DESC_SEARCH) return "desc-search";
            if(p == Projection.DESC_REGEX) return "desc-regex";
            if(p == Projection.FUNDAMENTAL) return "fundamental";

            throw new System.Exception("Invalid Projection Value. ProjectionToString");
        }
    }
}