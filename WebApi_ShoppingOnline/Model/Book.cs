﻿namespace WebApi_ShoppingOnline.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
