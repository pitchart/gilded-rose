using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class InventoryItemFactory
    {
        public List<InventoryItem> Create(List<Item> items)
        {
            return items.Select(i => new InventoryItem(i)).ToList();
        }
    }
}