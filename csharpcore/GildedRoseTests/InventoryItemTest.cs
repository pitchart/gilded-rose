using System.Collections.Generic;
using GildedRoseKata;
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
        public void SellByDate_IsPassed_WhenSellInIsNegative()
        {
            var inventoryItem = new InventoryItem(new Item { Name = "sell in negative", SellIn = -1, Quality = 2 });

            Assert.True(inventoryItem.HasSellByDatePast);
        }

        [Fact]
        public void SellByDate_IsNotPassed_WhenSellInIsPositive()
        {
            var inventoryItem = new InventoryItem(new Item { Name = "sell in negative", SellIn = 1, Quality = 2 });

            Assert.False(inventoryItem.HasSellByDatePast);
        }
    }
}
