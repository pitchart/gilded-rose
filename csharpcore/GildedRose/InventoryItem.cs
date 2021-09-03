namespace GildedRoseKata
{
    public class InventoryItem
    {
        public string Name { get; }
        
        public int Quality { get; set; }

        public int SellIn { get; set; }

        public InventoryItem(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }
    }
}
