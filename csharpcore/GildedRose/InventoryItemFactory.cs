using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class InventoryItemFactory
    {
        public IList<InventoryItem> Create(IList<Item> items)
        {
            return items.Select(i => (i.Name == GildedRose.ItemNameBackstagePasses) ? new BackstagePass(i) : new InventoryItem(i)).ToList();
        }
    }
}
