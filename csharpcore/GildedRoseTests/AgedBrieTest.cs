using GildedRoseKata.Domain;
using Xunit;

namespace GildedRoseTests
{
    public class AgedBrieTest
    {
        [Fact]
        public void At_the_end_of_each_day_quality_increases_and_sellin_decreases()
        {
            var item = new AgedBrie("brie", 10, 30);

            item.GetOld();

            Assert.Equal(29, item.SellIn);
            Assert.Equal(11, item.Quality);
        }

        [Fact]
        public void Quality_is_never_more_than_50()
        {
            var item = new AgedBrie("brie", 50, 8);
            item.GetOld();

            Assert.Equal(50, item.Quality);
        }
    }
}
