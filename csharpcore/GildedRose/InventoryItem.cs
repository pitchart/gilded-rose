namespace GildedRoseKata
{
    public class InventoryItem
    {
        public string Name { get; }
        
        public int Quality { get; set; }

        public int SellIn { get; set; }

        public bool HasSellByDatePast => SellIn < 0;

        public InventoryItem(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }
    }
}
