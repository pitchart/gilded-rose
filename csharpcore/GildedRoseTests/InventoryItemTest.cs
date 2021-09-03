using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Domain;
using Xunit;

namespace GildedRoseTests
{
    public class InventoryItemTest
    {
        [Fact]
        public void MapItemToInventoryItem()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 2 } };

            var inventoryItems = new InventoryItemFactory().Create(items);

            Assert.Equal(items[0].Name, inventoryItems[0].Name);
            Assert.Equal(items[0].SellIn, inventoryItems[0].SellIn);
            Assert.Equal(items[0].Quality, inventoryItems[0].Quality);
        }

        [Fact]
        public void At_the_end_of_each_day_quality_and_sellin_decreases()
        {
            var item = new InventoryItem("elixir", 10, 30);

            item.GetOld();

            Assert.Equal(29, item.SellIn);
            Assert.Equal(9, item.Quality);
        }

        [Fact]
        public void Quality_is_never_negative()
        {
            var item = new InventoryItem("elixir", 0, 8);
            item.GetOld();

            Assert.Equal(0, item.Quality);
        }
    }
}
