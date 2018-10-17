using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            var symbolEncoded = WebUtility.UrlEncode(symbol);
            var url = GetUrl($"/stock/{symbolEncoded}/company");
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
            var symbolEncoded = WebUtility.UrlEncode(symbol);
            var url = GetUrl($"/stock/{symbolEncoded}/quote");
            var response = GetResponseForUrl(url);

            if (response.IsSuccessStatusCode)
            {
                var quote = response.Content.ReadAsAsync<Quote>().GetAwaiter().GetResult();
                return quote;
            }

            return null;
        }

        public List<BatchResult> GetBatchData(string[] symbols, string[] types)
        {
            if (symbols == null)
            {
                throw new ArgumentException("symbols parameter cannot be null!");
            }

            if (types == null)
            {
                throw new ArgumentException("types parameter cannot be null!");
            }
              
            var symbolList = WebUtility.UrlEncode(string.Join(",", symbols));
            var typeList = WebUtility.UrlEncode(string.Join(",", types));
            var url = GetUrl($"/stock/market/batch?symbols={symbolList}&types={typeList}");

            var response = GetResponseForUrl(url);

            if (response.IsSuccessStatusCode)
            {
                var companyDataList = response.Content.ReadAsAsync<Dictionary<string, BatchResult>>().GetAwaiter().GetResult();
                return companyDataList.Values.ToList();
            }

            return new List<BatchResult>();
        }

        private string GetUrl(string endpoint)
        {
            return api_root + endpoint;
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
