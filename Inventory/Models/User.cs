using System;
namespace Inventory.Models
{
    public class User
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public string FirstName { set; get; }
        public string OtherNames { set; get; }
        public int Id { set; get; }
        public string IsActive { set; get; }
        public string IsAdmin { set; get; }


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

