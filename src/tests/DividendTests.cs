using System;
using System.Linq;
using Xunit;

namespace IEXAPI.Tests
{
    public class DividendTests
    {
        [Fact]
        public void SingleCompanyCall()
        {
            string symbol = "MSFT";
            var iex = new IEXClient();
            var dividend = iex.GetDividend(symbol, Range.OneYear);

            Assert.NotNull(dividend);
            Assert.True(dividend.Count > 0);

            var div = dividend.FirstOrDefault();
            Assert.True(div.Amount > 0);
        }

    }
}
