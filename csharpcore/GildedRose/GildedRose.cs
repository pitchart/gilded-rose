using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public const string ItemNameBackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        private const string ItemNameAgedBrie = "Aged Brie";
        private const string ItemNameSulfuras = "Sulfuras, Hand of Ragnaros";

        IList<InventoryItem> Items;

        public GildedRose(IList<InventoryItem> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var inventoryItem in Items)
            {
                if (inventoryItem is BackstagePass)
                {
                    (inventoryItem as BackstagePass).GetOld();
                }
                else
                {
                    ProcessItem(inventoryItem);
                }
            }
        }

        private void ProcessItem(InventoryItem item)
        {
            if (item.Name != ItemNameAgedBrie && item.Name != ItemNameBackstagePasses)
            {
                if (item.Quality > 0)
                {
                    if (item.Name != ItemNameSulfuras)
                    {
                        item.Quality -= 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;
                }
            }

            if (item.Name != ItemNameSulfuras)
            {
                item.SellIn -= 1;
            }

            if (!item.HasSellByDatePast)
            {
                return;
            }

            if (item.Name != ItemNameAgedBrie)
            {
                if (item.Quality > 0 && item.Name != ItemNameSulfuras)
                {
                    item.Quality -= 1;
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;
                }
            }
        }
    }
}
