using System;
using System.Collections.Generic;
using System.Linq;
using GildedRoseKata.Domain;

namespace GildedRoseKata
{
    public class InventoryItemFactory
    {
        private const string ItemNameBackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        private const string ItemNameAgedBrie = "Aged Brie";
        private const string ItemNameSulfuras = "Sulfuras, Hand of Ragnaros";
        private const string ItemNameConjured = "Conjured Mana Cake";

        private readonly Func<Item, InventoryItem> Mapping = i =>
            i.Name == ItemNameBackstagePasses ? new BackstagePass(i.Name, i.Quality, i.SellIn) :
            i.Name == ItemNameAgedBrie ? new AgedBrie(i.Name, i.Quality, i.SellIn) :
            i.Name == ItemNameSulfuras ? new Sulfuras(i.Name, i.Quality, i.SellIn) :
            i.Name == ItemNameConjured ? new Conjured(i.Name, i.Quality, i.SellIn) :
            new InventoryItem(i.Name, i.Quality, i.SellIn);

        public IList<InventoryItem> Create(IList<Item> items)
        {
            return items.Select(Mapping).ToList();
        }
    }
}
