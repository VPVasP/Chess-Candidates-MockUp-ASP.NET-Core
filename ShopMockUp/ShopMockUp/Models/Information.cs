namespace ShopMockUp.Models
{
    public class Information
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<ShopItemInformation>? shopItemInformation { get; set; }
    }
}
