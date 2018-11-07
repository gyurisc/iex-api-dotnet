using Shouldly;
using System;
using Xunit;

namespace IEXAPI.Tests
{
    public class KeyStatTests
    {
        [Fact]
        public void GetSingleCompanyStat()
        {
            string symbol = "MSFT";
            var iex = new IEXClient();
            var stats = iex.GetStats(symbol);

            Assert.NotNull(stats);
            stats.CompanyName.ShouldBe("Microsoft Corporation");

            Assert.True(stats.Week52Low > 0);
            Assert.True(stats.Week52High > 0);
        }

        [Fact]
        public void GetGoogleStat()
        {
            string symbol = "GOOG";
            var iex = new IEXClient();
            var stats = iex.GetStats(symbol);

            Assert.NotNull(stats);
            stats.CompanyName.ShouldBe("Alphabet Inc.");

            Assert.True(stats.Week52Low > 0);
            Assert.True(stats.Week52High > 0);
        }

        [Fact]
        public void GetNaNValuesCorrectly()
        {
            string symbol = "ALGR";
            var iex = new IEXClient();
            var stats = iex.GetStats(symbol);

            Assert.NotNull(stats);
            stats.CompanyName.ShouldBe("Allegro Merger Corp.");
            Assert.True(stats.Week52Low > 0);
            Assert.True(stats.Week52High > 0);
        }
    }
}
