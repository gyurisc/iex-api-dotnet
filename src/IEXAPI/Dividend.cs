using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEXAPI
{
    public enum Qualified { P, Q, N };

    public enum TypeEnum { DividendIncome };

    public class Dividend
    {        
        [JsonProperty("exDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExDate { get; set; }

        [JsonProperty("paymentDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PaymentDate { get; set; }

        [JsonProperty("recordDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RecordDate { get; set; }

        [JsonProperty("declaredDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DeclaredDate { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        [JsonProperty("flag", NullValueHandling = NullValueHandling.Ignore)]
        public string Flag { get; set; }

        /// <summary>
        /// refers to the dividend payment type (Dividend income, Interest income, Stock dividend, Short term capital gain, Medium term capital gain, Long term capital gain, Unspecified term capital gain)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// refers to the dividend income type 
        /// P = Partially qualified income
        /// Q = Qualified income
        /// N = Unqualified income 
        /// null = N/A or unknown
        /// </summary>
        [JsonProperty("qualified", NullValueHandling = NullValueHandling.Ignore)]
        public Qualified? Qualified { get; set; }

        /// <summary>
        /// refers to the indicated rate of the dividend
        /// </summary>
        [JsonProperty("indicated", NullValueHandling = NullValueHandling.Ignore)]
        public string Indicated { get; set; }
    }
}
