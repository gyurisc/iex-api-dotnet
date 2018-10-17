using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEXAPI
{
    public partial class Chart
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Open { get; set; }

        [JsonProperty("high", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? High { get; set; }

        [JsonProperty("low", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Low { get; set; }

        [JsonProperty("close", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Close { get; set; }

        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public long? Volume { get; set; }

        [JsonProperty("unadjustedVolume", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnadjustedVolume { get; set; }

        [JsonProperty("change", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Change { get; set; }

        [JsonProperty("changePercent", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ChangePercent { get; set; }

        [JsonProperty("vwap", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Vwap { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("changeOverTime", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ChangeOverTime { get; set; }
    }

}
