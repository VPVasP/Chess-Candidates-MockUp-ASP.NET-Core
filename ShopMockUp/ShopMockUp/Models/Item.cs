namespace ShopMockUp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string imageURL { get; set; }
        public double price { get; set; }

        public List<ShopItemInformation>? shopItemInformation { get; set; }

    }
}
