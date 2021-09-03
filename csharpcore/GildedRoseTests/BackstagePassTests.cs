using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class BackstagePassTests
    {
        [Fact]
        public void At_the_end_of_each_day_our_system_lowers_both_values_for_every_item()
        {
            var item = new BackstagePass(new Item {Name = "concert", Quality = 10, SellIn = 30});

            item.GetOld();

            Assert.Equal(29, item.SellIn);
            Assert.Equal(9, item.Quality);
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
            var item = new BackstagePass(new Item {Name = "concert", Quality = 10, SellIn = 11});
            item.GetOld();

            Assert.Equal(12, item.Quality);

        }

        [Fact]
        public void Quality_increases_by_3_when_there_are_5_days_or_less()
        {
            var item = new BackstagePass(new Item {Name = "concert", Quality = 10, SellIn = 6});
            item.GetOld();

            Assert.Equal(13, item.Quality);

        }

        [Fact]
        public void Quality_is_never_negative()
        {
            var item = new BackstagePass(new Item {Name = "concert", Quality = 0, SellIn = 20});
            item.GetOld();

            Assert.Equal(0, item.Quality);
        }
    }
}
