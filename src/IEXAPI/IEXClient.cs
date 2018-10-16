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
            var endpoint = GetEndpoint("/ref-data/symbols");
            var response = GetResponseForUrl(endpoint);

            if (response.IsSuccessStatusCode)
            {
                var symbols = response.Content.ReadAsAsync<List<SymbolReferenceData>>().GetAwaiter().GetResult();
                return symbols;
            }

            return new List<SymbolReferenceData>();
        }

        private string GetEndpoint(string endpoint)
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
