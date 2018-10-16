using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace IEXAPI
{
    public class IEXClient
    {
        private string api_root = "https://api.iextrading.com/1.0";

        public List<SymbolReferenceData> GetSymbols()
        {
            var endpoint = GetUrl("/ref-data/symbols");
            var response = GetResponseForUrl(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var symbols = response.Content.ReadAsAsync<List<SymbolReferenceData>>().GetAwaiter().GetResult();
                return symbols;
            }

            return new List<SymbolReferenceData>();
        }

        public Company GetCompany(string symbol)
        {
            var url = GetUrl("/stock/{0}/company", symbol);
            var response = GetResponseForUrl(url);

            if (response.IsSuccessStatusCode)
            {
                var companyData = response.Content.ReadAsAsync<Company>().GetAwaiter().GetResult();
                return companyData;
            }

            return null;
        }

        public Quote GetStockQuote(string symbol)
        {
            var url = GetUrl("/stock/{0}/quote", symbol);
            var response = GetResponseForUrl(url);

            if (response.IsSuccessStatusCode)
            {
                var quote = response.Content.ReadAsAsync<Quote>().GetAwaiter().GetResult();
                return quote;
            }

            return null;
        }

        private string GetUrl(string endpoint)
        {
            return api_root + endpoint;
        }

        private string GetUrl(string endpoint, string symbol)
        {
            return api_root + string.Format(endpoint, symbol);
        }

        public static HttpResponseMessage GetResponseForUrl(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                client.BaseAddress = new Uri(url);
                HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
                return response;
            }
        }
    }
}
