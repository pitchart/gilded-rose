using GildedRoseKata.Domain;
using Xunit;

namespace GildedRoseTests
{
    public class SulfurasTest
    {
        [Fact]
        public void At_the_end_of_each_day_quality_never_changes()
        {
            var item = new Sulfuras("sulfuras", 10, 30);

            item.GetOld();

            Assert.Equal(30, item.SellIn);
            Assert.Equal(10, item.Quality);
        }
    }
}
