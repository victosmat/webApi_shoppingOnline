﻿namespace WebApi_ShoppingOnline.Entity
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public Account Account { get; set; }    
    }
}
