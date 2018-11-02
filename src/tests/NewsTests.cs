using System;
using Xunit;

namespace IEXAPI.Tests
{
    public class NewsTests
    {
        [Fact]
        public void GetNewsForSingleCompany()
        {
            string symbol = "AAPL";
            var iex = new IEXClient();
            var news = iex.GetNews(symbol);

            Assert.NotNull(news);
            Assert.NotEmpty(news);
        }

        [Fact]
        public void GetLastOneNewsFoirSingleCompany()
        {
            string symbol = "AAPL";
            var iex = new IEXClient();
            var news = iex.GetNews(symbol, last: 1);

            Assert.NotNull(news);
            Assert.Single(news);
        }
    }
}
