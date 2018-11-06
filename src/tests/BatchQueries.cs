using Shouldly;
using System;
using System.Linq;
using Xunit;

namespace IEXAPI.Tests
{
    public class BatchQueries
    {
        string[] symbols = new[] { "aapl", "msft", "goog", "fb" };

        [Fact]
        public void GetQuoteAndCompanyInformationInBatchQuery()
        {
            var iex = new IEXClient();
            var types = new[] { "company", "quote" };
            var resultList = iex.GetBatchData(symbols, types);

            resultList.ShouldNotBeNull();
            resultList.Count.ShouldBe(symbols.Length);

            var aapl = resultList.FirstOrDefault();

            aapl.ShouldNotBeNull();
            aapl.company.ShouldNotBeNull();
            aapl.company.companyName.ShouldNotBeNull();
            aapl.company.symbol.ShouldNotBeNull();

            string symbol = aapl.company.symbol;
            symbol.ShouldBe("AAPL");

            aapl.quote.ShouldNotBeNull();
            aapl.quote.Close.ShouldNotBeNull();
            double close = aapl.quote.Close ?? 0;
            close.ShouldBeGreaterThan(0);

        }

        [Fact]
        public void GetNewsForInBatchQuery()
        {
            var iex = new IEXClient();
            var types = new[] { "stats", "quote" };
            var resultList = iex.GetBatchData(symbols, types);

            resultList.ShouldNotBeNull();
            resultList.Count.ShouldBe(symbols.Length);

            var aapl = resultList.FirstOrDefault();
            aapl.quote.ShouldNotBeNull();
            aapl.stats.ShouldNotBeNull();

            var exDivDate = aapl.stats.ExDividendDate;
            exDivDate.ShouldNotBeNullOrEmpty();
        }
    }
}
