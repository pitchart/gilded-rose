using GildedRoseKata.Domain;

namespace GildedRoseKata
{
    public class QualityUpdateService
    {
        public void Execute(InventoryItem inventoryItem)
        {
            inventoryItem.GetOld();
        }
    }
}
