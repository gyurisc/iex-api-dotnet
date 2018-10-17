using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEXAPI
{
    public class SymbolReferenceData
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("iexId")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long IexId { get; set; }
    }
}
