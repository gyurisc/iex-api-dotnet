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

        public List<Dividend> GetDividend(string symbol, Range queryRange)
        {
            if (string.IsNullOrEmpty(symbol))
            {
                throw new ArgumentException("Symbol cannot be empty!");
            }

            var symbolEncoded = WebUtility.UrlEncode(symbol);
            var rangeParam = queryRange.GetDescription();

            if (string.IsNullOrEmpty(rangeParam))
            {
                throw new ArgumentException("Wrong range parameter! Failed to convert to strign value");
            }

            var url = GetUrl($"/stock/{symbolEncoded}/dividends/{rangeParam}");

            var response = GetResponseForUrl(url);

            if (response.IsSuccessStatusCode)
            {
                var divList = response.Content.ReadAsAsync<List<Dividend>>().GetAwaiter().GetResult();
                return divList;
            }

            return null;
        }

        public List<News> GetNews(string symbol, int last = -1)
        {
            if (string.IsNullOrEmpty(symbol))
            {
                throw new ArgumentException("Symbol cannot be empty!");
            }

            var symbolEncoded = WebUtility.UrlEncode(symbol);
            var url = GetUrl($"/stock/{symbolEncoded}/news");

            if (last > 50)
            {
                throw new ArgumentException("Last parameter cannot be larger than 50");
            }

            if (last > 0)
            {
                url += $"/latest/{last}";
            }

            var response = GetResponseForUrl(url);

            if (response.IsSuccessStatusCode)
            {
                var newsList = response.Content.ReadAsAsync<List<News>>().GetAwaiter().GetResult();
                return newsList;
            }

            return null;
        }

        public KeyStat GetStats(string symbol)
        {
            if (string.IsNullOrEmpty(symbol))
            {
                throw new ArgumentException("Symbol cannot be empty!");
            }

            var symbolEncoded = WebUtility.UrlEncode(symbol);
            var url = GetUrl($"/stock/{symbolEncoded}/stats");

            var response = GetResponseForUrl(url);

            if (response.IsSuccessStatusCode)
            {
                var stat = response.Content.ReadAsAsync<KeyStat>().GetAwaiter().GetResult();
                return stat;
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

            if (types.Count() > 10)
            {
                throw new ArgumentException("Only 10 different type parameter supported per call.");
            }

            if (symbols.Count() > 100)
            {
                throw new ArgumentException("Symbol limit exceeded. Only 100 symbols can be specified per call.");
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
