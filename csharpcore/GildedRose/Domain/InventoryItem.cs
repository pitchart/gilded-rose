using System;

namespace GildedRoseKata.Domain
{
    public class InventoryItem
    {
        public string Name { get; }

        public int Quality { get; set; }

        public int SellIn { get; set; }

        protected bool HasSellByDatePast => SellIn < 0;

        public InventoryItem(string name, int quality, int sellIn)
        {
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }

        public virtual void GetOld()
        {
            SellIn -= 1;
            Quality = Math.Max(0, !HasSellByDatePast ? Quality - 1 : Quality - 2);
        }
    }
}
