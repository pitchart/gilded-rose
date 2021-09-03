using System;

namespace GildedRoseKata.Domain
{
    public class Conjured : InventoryItem
    {
        public Conjured(string name, int quality, int sellIn) : base(name, quality, sellIn)
        {
        }

        public override void GetOld()
        {
            SellIn -= 1;
            Quality = Math.Max(0, !HasSellByDatePast ? Quality - 2 : Quality - 4);
        }
    }
}
