using System;
namespace Inventory.Models
{
    public class Product
    {
        public string Username { set; get; }
        public string Password { set; get; }

        public Product(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Product()
        {
        }
    }
}

