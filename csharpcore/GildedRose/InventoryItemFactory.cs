using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class InventoryItemFactory
    {
        public IList<InventoryItem> Create(IList<Item> items)
        {
            return items.Select(i => new InventoryItem(i)).ToList();
        }
    }
}