using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class BackstagePassTests
    {
        [Fact]
        public void At_the_end_of_each_day_quality_increases_and_sellin_decreases()
        {
            var item = new BackstagePass(new Item {Name = "concert", Quality = 10, SellIn = 30});

            item.GetOld();

            Assert.Equal(29, item.SellIn);
            Assert.Equal(11, item.Quality);
        }

        [Fact]
        public void Quality_drops_to_zero_after_the_concert()
        {
            var item = new BackstagePass(new Item {Name = "concert", Quality = 10, SellIn = 0});

            item.GetOld();

            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void Quality_increases_by_2_when_there_are_10_days_or_less()
        {
            var item = new BackstagePass(new Item {Name = "concert", Quality = 10, SellIn = 10});
            item.GetOld();

            Assert.Equal(12, item.Quality);

        }

        [Fact]
        public void Quality_increases_by_3_when_there_are_5_days_or_less()
        {
            var item = new BackstagePass(new Item {Name = "concert", Quality = 10, SellIn = 5});
            item.GetOld();

            Assert.Equal(13, item.Quality);

        }

        [Fact]
        public void Quality_is_never_more_than_50()
        {
            var item = new BackstagePass(new Item {Name = "concert", Quality = 50, SellIn = 8});
            item.GetOld();

            Assert.Equal(50, item.Quality);
        }
    }
}
