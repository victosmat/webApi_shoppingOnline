﻿namespace WebApi_ShoppingOnline.Entity
{
    public class Cart
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public User User { get; set; }
    }
}