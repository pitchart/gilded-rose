using System;

namespace GildedRoseKata
{
    public class BackstagePass : InventoryItem
    {
        public BackstagePass(Item item): base(item)
        {
        }

        public void GetOld()
        {
            SellIn--;

            if (SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn < 5)
            {
                Quality = Math.Min(Quality + 3, 50);
            }
            else if (SellIn < 10)
            {
                Quality = Math.Min(Quality + 2, 50);
            }
            else
            {
                Quality = Math.Min(Quality + 1, 50);
            }
        }
    }
}
