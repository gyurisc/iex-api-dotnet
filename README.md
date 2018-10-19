iex-api-dotnet
==============

Unofficial API for using the IEX Trading service

Currently still work in-progress

IEX
-----

IEX is the stock exchange built for investors and companies.

The IEX API is a set of services designed for developers and engineers. It can be used to build high-quality apps and services. We’re always working to improve the IEX API. Please check back for enhancements and improvements.

The IEX API Documentations can be found here: (IEX API Documentation)[https://iextrading.com/developer/docs/]

Usage
----- 

### Company information 

```csharp
string symbol = "msft";

var iex = new IEXClient();

var company = iex.GetCompany(symbol);
if (company != null)
{
	Console.WriteLine($"{company.companyName} - ({company.symbol})");
	Console.WriteLine($"CEO: {company.CEO}");
	Console.WriteLine($"Website: {company.website}");
}
```

### Price information 
```csharp
string symbol = "msft";

var iex = new IEXClient();
            
var quote = iex.GetStockQuote(symbol);
if (quote != null)
{
    Console.WriteLine($"Price: {quote.LatestPrice:C}");           
    Console.WriteLine($"Open-Close: {quote.Open:C}-{quote.Close:C}");
    Console.WriteLine($"Change: {quote.Change} ({quote.ChangePercent:P})");
    Console.WriteLine($"52 Week Range: {quote.Week52Low:C}-{quote.Week52High:C}");
}
```

### Dividends

```csharp
string symbol = "msft";

var iex = new IEXClient();
            
var divs = iex.GetDividend(symbol, Range.OneYear);

if (divs != null)
{
    Console.WriteLine("Dividends:");
    foreach (var div in divs)
    {
        Console.WriteLine($"{div.RecordDate:dd-MMM-yyy} - {div.Amount:C}");
    }
}
```

Todo
----

Define types and definitions for specific API operations:

- Stocks
- Quote
- Chart
- ~~Batch Requests~~
- Book
- Open / Close
- Previous
- ~~Company~~
- Key Stats
- Peers
- Relevant
- News
- Financials
- Earnings
- ~~Dividends~~
- Splits
- Logo
- Price
- Delayed Quote
- List
- Effective Spread
- Volume by Venue

Reference Data

 - ~~Symbols~~
 
IEX Market Data
 - TOPS
 - Last
 - HIST
 - DEEP
 - Book
 - Trades
 - System Event
 - Trading Status
 - Operational Halt Status
 - Short Sale Price Test Status
 - Security Event
 - Trade Break
 - Auction
 
IEX Stats

 - Intraday
 - Recent
 - Records
 - Historical Summary
 - Historical Daily
 
Markets

- Market
