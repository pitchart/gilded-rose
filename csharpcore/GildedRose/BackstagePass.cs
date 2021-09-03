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
            else if (SellIn <= 5)
            {
                Quality += 3;
            }
            else if (SellIn <= 10)
            {
                Quality += 2;
            }
            else
            {
                Quality = Math.Max(0, Quality - 1);
            }

        }
    }
}
