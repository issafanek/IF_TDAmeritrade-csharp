using Newtonsoft.Json;
using System;

namespace TDAmeritrade.Services.Instruments.Models
{
    public class FundamentalData
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("high52")]
        public decimal High52 { get; set; }

        [JsonProperty("low52")]
        public decimal Low52 { get; set; }

        [JsonProperty("dividendAmount")]
        public decimal DividendAmount { get; set; }

        [JsonProperty("dividendYield")]
        public decimal DividendYield { get; set; }

        [JsonProperty("dividendDate")]
        public DateTime DividendDate { get; set; }

        [JsonProperty("peRatio")]
        public decimal PeRatio { get; set; }

        [JsonProperty("pegRatio")]
        public decimal PegRatio { get; set; }

        [JsonProperty("pbRatio")]
        public decimal PbRatio { get; set; }

        [JsonProperty("prRatio")]
        public decimal PrRatio { get; set; }

        [JsonProperty("pcfRatio")]
        public decimal PcfRatio { get; set; }

        [JsonProperty("grossMarginTTM")]
        public decimal GrossMarginTtm { get; set; }

        [JsonProperty("grossMarginMRQ")]
        public decimal GrossMarginMrq { get; set; }

        [JsonProperty("netProfitMarginTTM")]
        public decimal NetProfitMarginTtm { get; set; }

        [JsonProperty("netProfitMarginMRQ")]
        public decimal NetProfitMarginMrq { get; set; }

        [JsonProperty("operatingMarginTTM")]
        public decimal OperatingMarginTtm { get; set; }

        [JsonProperty("operatingMarginMRQ")]
        public decimal OperatingMarginMrq { get; set; }

        [JsonProperty("returnOnEquity")]
        public decimal ReturnOnEquity { get; set; }

        [JsonProperty("returnOnAssets")]
        public decimal ReturnOnAssets { get; set; }

        [JsonProperty("returnOnInvestment")]
        public decimal ReturnOnInvestment { get; set; }

        [JsonProperty("quickRatio")]
        public decimal QuickRatio { get; set; }

        [JsonProperty("currentRatio")]
        public decimal CurrentRatio { get; set; }

        [JsonProperty("interestCoverage")]
        public decimal InterestCoverage { get; set; }

        [JsonProperty("totalDebtToCapital")]
        public decimal TotalDebtToCapital { get; set; }

        [JsonProperty("ltDebtToEquity")]
        public decimal LtDebtToEquity { get; set; }

        [JsonProperty("totalDebtToEquity")]
        public decimal TotalDebtToEquity { get; set; }

        [JsonProperty("epsTTM")]
        public decimal EpsTtm { get; set; }

        [JsonProperty("epsChangePercentTTM")]
        public decimal EpsChangePercentTtm { get; set; }

        [JsonProperty("epsChangeYear")]
        public decimal EpsChangeYear { get; set; }

        [JsonProperty("epsChange")]
        public decimal EpsChange { get; set; }

        [JsonProperty("revChangeYear")]
        public decimal RevChangeYear { get; set; }

        [JsonProperty("revChangeTTM")]
        public decimal RevChangeTtm { get; set; }

        [JsonProperty("revChangeIn")]
        public decimal RevChangeIn { get; set; }

        [JsonProperty("sharesOutstanding")]
        public decimal SharesOutstanding { get; set; }

        [JsonProperty("marketCapFloat")]
        public decimal MarketCapFloat { get; set; }

        [JsonProperty("marketCap")]
        public decimal MarketCap { get; set; }

        [JsonProperty("bookValuePerShare")]
        public decimal BookValuePerShare { get; set; }

        [JsonProperty("shortIntToFloat")]
        public decimal ShortIntToFloat { get; set; }

        [JsonProperty("shortIntDayToCover")]
        public decimal ShortIntDayToCover { get; set; }

        [JsonProperty("divGrowthRate3Year")]
        public decimal DivGrowthRate3Year { get; set; }

        [JsonProperty("dividendPayAmount")]
        public decimal DividendPayAmount { get; set; }

        [JsonProperty("dividendPayDate")]
        public DateTime DividendPayDate { get; set; }

        [JsonProperty("beta")]
        public decimal Beta { get; set; }

        [JsonProperty("vol1DayAvg")]
        public decimal Vol1DayAvg { get; set; }

        [JsonProperty("vol10DayAvg")]
        public decimal Vol10DayAvg { get; set; }

        [JsonProperty("vol3MonthAvg")]
        public decimal Vol3MonthAvg { get; set; }
    }
}