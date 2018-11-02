using System;
using Xunit;
using Shouldly;
using System.Linq;

namespace IEXAPI.Tests
{
    public class CompanyTests
    {
        [Fact]
        public void SingleCompanyCall()
        {
            string symbol = "MSFT";
            var iex = new IEXClient();
            var company = iex.GetCompany(symbol);

            Assert.NotNull(company);
            company.symbol.ShouldBe(symbol);
            company.exchange.ShouldBe("Nasdaq Global Select");
            company.companyName.ShouldBe("Microsoft Corporation");
            company.industry.ShouldBe("Application Software");
        }

        [Fact]
        public void BatchCompanyCall()
        {
            var symbols = new string[] { "MSFT", "AAPL"};
            var types = new[] { "company" };

            var iex = new IEXClient();
            var result = iex.GetBatchData(symbols, types);

            Assert.NotNull(result);
            result.Count.ShouldBe(2);

            var msft = result.Where(i => i.company.symbol == "MSFT").FirstOrDefault();
            Assert.NotNull(msft);
            msft.company.symbol.ShouldBe("MSFT");

            var aapl = result.Where(i => i.company.symbol == "AAPL").FirstOrDefault();
            Assert.NotNull(aapl);
            aapl.company.symbol.ShouldBe("AAPL");
        }
    }
}
