using IEXAPI;
using System;

namespace IEXSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = "msft";

            var iex = new IEXClient();

            var company = iex.GetCompany(symbol);
            if (company != null)
            {
                Console.WriteLine($"{company.companyName} - ({company.symbol})");
                Console.WriteLine($"CEO: {company.CEO}");
                Console.WriteLine($"Website: {company.website}");
            }

            var quote = iex.GetStockQuote(symbol);
            if (quote != null)
            {
                Console.WriteLine($"Price: {quote.LatestPrice:C}");           
                Console.WriteLine($"Open-Close: {quote.Open:C}-{quote.Close:C}");
                Console.WriteLine($"Change: {quote.Change} ({quote.ChangePercent:P})");
                Console.WriteLine($"52 Week Range: {quote.Week52Low:C}-{quote.Week52High:C}");
            }

            var divs = iex.GetDividend(symbol, Range.OneYear);

            if (divs != null)
            {
                Console.WriteLine("Dividends:");
                foreach (var div in divs)
                {
                    Console.WriteLine($"{div.RecordDate:dd-MMM-yyy} - {div.Amount:C}");
                }
            }
        }
    }
}
