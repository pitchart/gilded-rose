using System;

namespace GildedRoseKata.Domain
{
    public class AgedBrie : InventoryItem
    {
        public AgedBrie(string name, int quality, int sellIn) : base(name, quality, sellIn)
        {
        }

        public override void GetOld()
        {
            SellIn--;
            Quality = Math.Min(!HasSellByDatePast ? Quality + 1: Quality + 2, 50);
        }
    }
}
