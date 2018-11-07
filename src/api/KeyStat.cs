using Newtonsoft.Json;
using System;

namespace IEXAPI
{
    public partial class KeyStat
    {
        [JsonProperty("companyName", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("marketcap", NullValueHandling = NullValueHandling.Ignore)]
        public long? Marketcap { get; set; }

        [JsonProperty("beta", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Beta { get; set; }

        [JsonProperty("week52high", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Week52High { get; set; }

        [JsonProperty("week52low", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Week52Low { get; set; }

        [JsonProperty("week52change", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Week52Change { get; set; }

        [JsonProperty("shortInterest", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShortInterest { get; set; }

        [JsonProperty("shortDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortDate { get; set; }

        [JsonProperty("dividendRate", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DividendRate { get; set; }

        [JsonProperty("dividendYield", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DividendYield { get; set; }

        [JsonProperty("exDividendDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ExDividendDate { get; set; }

        [JsonProperty("latestEPS", NullValueHandling = NullValueHandling.Ignore)]
        public long? LatestEps { get; set; }

        [JsonProperty("latestEPSDate", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestEpsDate { get; set; }

        [JsonProperty("sharesOutstanding", NullValueHandling = NullValueHandling.Ignore)]
        public long? SharesOutstanding { get; set; }

        [JsonProperty("float", NullValueHandling = NullValueHandling.Ignore)]
        public long? Float { get; set; }

        [JsonProperty("returnOnEquity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ReturnOnEquity { get; set; }

        [JsonProperty("consensusEPS", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ConsensusEps { get; set; }

        [JsonProperty("numberOfEstimates", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumberOfEstimates { get; set; }

        [JsonProperty("EPSSurpriseDollar")]
        public object EpsSurpriseDollar { get; set; }

        [JsonProperty("EPSSurprisePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? EpsSurprisePercent { get; set; }

        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("EBITDA", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ebitda { get; set; }

        [JsonProperty("revenue", NullValueHandling = NullValueHandling.Ignore)]
        public long? Revenue { get; set; }

        [JsonProperty("grossProfit", NullValueHandling = NullValueHandling.Ignore)]
        public long? GrossProfit { get; set; }

        [JsonProperty("cash", NullValueHandling = NullValueHandling.Ignore)]
        public long? Cash { get; set; }

        [JsonProperty("debt", NullValueHandling = NullValueHandling.Ignore)]
        public long? Debt { get; set; }

        [JsonProperty("ttmEPS", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TtmEps { get; set; }

        [JsonProperty("revenuePerShare", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenuePerShare { get; set; }

        [JsonProperty("revenuePerEmployee", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenuePerEmployee { get; set; }

        [JsonProperty("peRatioHigh", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PeRatioHigh { get; set; }

        [JsonProperty("peRatioLow", NullValueHandling = NullValueHandling.Ignore)]
        public long? PeRatioLow { get; set; }

        [JsonProperty("returnOnAssets", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ReturnOnAssets { get; set; }

        [JsonProperty("returnOnCapital")]
        public object ReturnOnCapital { get; set; }

        [JsonProperty("profitMargin", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ProfitMargin { get; set; }

        [JsonProperty("priceToSales", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PriceToSales { get; set; }

        [JsonProperty("priceToBook", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PriceToBook { get; set; }

        [JsonProperty("day200MovingAvg", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Day200MovingAvg { get; set; }

        [JsonProperty("day50MovingAvg", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Day50MovingAvg { get; set; }

        [JsonProperty("institutionPercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? InstitutionPercent { get; set; }

        [JsonProperty("insiderPercent")]
        public object InsiderPercent { get; set; }

        [JsonProperty("shortRatio", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ShortRatio { get; set; }

        [JsonProperty("year5ChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Year5ChangePercent { get; set; }

        [JsonProperty("year2ChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Year2ChangePercent { get; set; }

        [JsonProperty("year1ChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Year1ChangePercent { get; set; }

        [JsonProperty("ytdChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? YtdChangePercent { get; set; }

        [JsonProperty("month6ChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Month6ChangePercent { get; set; }

        [JsonProperty("month3ChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Month3ChangePercent { get; set; }

        [JsonProperty("month1ChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Month1ChangePercent { get; set; }

        [JsonProperty("day5ChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Day5ChangePercent { get; set; }

        [JsonProperty("day30ChangePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Day30ChangePercent { get; set; }
    }
}
