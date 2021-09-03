﻿using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private const string ItemNameBackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        private const string ItemNameAgedBrie = "Aged Brie";
        private const string ItemNameSulfuras = "Sulfuras, Hand of Ragnaros";

        IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var t in Items)
            {
                ProcessItem(t);
            }
        }

        private void ProcessItem(Item item)
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

                    if (item.Name == ItemNameBackstagePasses)
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality += 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality += 1;
                            }
                        }
                    }
                }
            }

            if (item.Name != ItemNameSulfuras)
            {
                item.SellIn -= 1;
            }

            if (item.SellIn >= 0) return;
            if (item.Name != ItemNameAgedBrie)
            {
                if (item.Name != ItemNameBackstagePasses)
                {
                    if (item.Quality > 0 && item.Name != ItemNameSulfuras)
                    {
                        item.Quality -= 1;
                    }
                }
                else
                {
                    item.Quality = 0;
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
