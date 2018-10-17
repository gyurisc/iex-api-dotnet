using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEXAPI
{
    public class Quote
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("primaryExchange")]
        public string PrimaryExchange { get; set; }

        [JsonProperty("sector")]
        public string Sector { get; set; }

        [JsonProperty("calculationPrice")]
        public string CalculationPrice { get; set; }

        [JsonProperty("open")]
        public double? Open { get; set; }

        [JsonProperty("openTime")]
        public long? OpenTime { get; set; }

        [JsonProperty("close")]
        public double? Close { get; set; }

        [JsonProperty("closeTime")]
        public long? CloseTime { get; set; }

        [JsonProperty("high")]
        public double? High { get; set; }

        [JsonProperty("low")]
        public double? Low { get; set; }

        [JsonProperty("latestPrice")]
        public double? LatestPrice { get; set; }

        [JsonProperty("latestSource")]
        public string LatestSource { get; set; }

        [JsonProperty("latestTime")]
        public string LatestTime { get; set; }

        [JsonProperty("latestUpdate")]
        public long? LatestUpdate { get; set; }

        [JsonProperty("latestVolume")]
        public long? LatestVolume { get; set; }

        [JsonProperty("iexRealtimePrice")]
        public double? IexRealtimePrice { get; set; }

        [JsonProperty("iexRealtimeSize")]
        public long? IexRealtimeSize { get; set; }

        [JsonProperty("iexLastUpdated")]
        public long? IexLastUpdated { get; set; }

        [JsonProperty("delayedPrice")]
        public double? DelayedPrice { get; set; }

        [JsonProperty("delayedPriceTime")]
        public long? DelayedPriceTime { get; set; }

        [JsonProperty("extendedPrice")]
        public double? ExtendedPrice { get; set; }

        [JsonProperty("extendedChange")]
        public double? ExtendedChange { get; set; }

        [JsonProperty("extendedChangePercent")]
        public double? ExtendedChangePercent { get; set; }

        [JsonProperty("extendedPriceTime")]
        public long? ExtendedPriceTime { get; set; }

        [JsonProperty("previousClose")]
        public double? PreviousClose { get; set; }

        [JsonProperty("change")]
        public double? Change { get; set; }

        [JsonProperty("changePercent")]
        public double? ChangePercent { get; set; }

        [JsonProperty("iexMarketPercent")]
        public double? IexMarketPercent { get; set; }

        [JsonProperty("iexVolume")]
        public long? IexVolume { get; set; }

        [JsonProperty("avgTotalVolume")]
        public long? AvgTotalVolume { get; set; }

        [JsonProperty("iexBidPrice")]
        public long? IexBidPrice { get; set; }

        [JsonProperty("iexBidSize")]
        public long? IexBidSize { get; set; }

        [JsonProperty("iexAskPrice")]
        public long? IexAskPrice { get; set; }

        [JsonProperty("iexAskSize")]
        public long? IexAskSize { get; set; }

        [JsonProperty("marketCap")]
        public long? MarketCap { get; set; }

        [JsonProperty("peRatio")]
        public double? PeRatio { get; set; }

        [JsonProperty("week52High")]
        public double? Week52High { get; set; }

        [JsonProperty("week52Low")]
        public double? Week52Low { get; set; }

        [JsonProperty("ytdChange")]
        public double? YtdChange { get; set; }
    }

}
