namespace ShopMockUp.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public List<Items>? items { get; set; }
    }

}

