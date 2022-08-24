using System;
namespace Inventory.Models
{
    public class User
    {
        public string Username { set; get; }
        public string Password { set; get; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User()
        {
        }
    }
}

