﻿namespace ShopMockUp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Items>? itemsList { get; set; }
    }
}

