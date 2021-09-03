using GildedRoseKata.Domain;
using Xunit;

namespace GildedRoseTests
{
    public class ConjuredTest
    {
        [Fact]
        public void At_the_end_of_each_day_quality_and_sellin_decreases()
        {
            var item = new Conjured("conjured", 10, 30);

            item.GetOld();

            Assert.Equal(29, item.SellIn);
            Assert.Equal(8, item.Quality);
        }

        [Fact]
        public void Quality_is_never_negative()
        {
            var item = new Conjured("conjured", 0, 8);
            item.GetOld();

            Assert.Equal(0, item.Quality);
        }
    }
}
