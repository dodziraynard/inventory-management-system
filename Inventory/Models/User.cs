using Dapper;
using Inventory.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Inventory.Models
{
    public class User
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public string Surname { set; get; }
        public string OtherNames { set; get; }
        public int Id { set; get; }
        public int IsActive { set; get; }
        public int IsAdmin { set; get; }
        private MySqlConnection connection;

        public User()
        {
            connection = new DBConnection().GetConnection();
        }

        public User(string username, string password)
        {
            Username = username;
            Password = GetHashString(password);
            connection = new DBConnection().GetConnection();
        }

        public User(string username, string password, string surname, string otherNames, int isActive, int isAdmin)
        {
            Username = username;
            Password = GetHashString(password);
            Surname = surname;
            OtherNames = otherNames;
            IsActive = isActive;
            IsAdmin = isAdmin;
            connection = new DBConnection().GetConnection();
        }

        public int insertUser()
        {
            string query =
                $"INSERT INTO `users`(`Username`, `Surname`, `OtherNames`, `Password`, `IsActive`, `IsAdmin`) " +
                $"VALUES ('{Username}','{Surname}','{OtherNames}','{Password}','{IsActive}','{IsAdmin}')";
            return connection.Execute(query);
        }

        public int updateUser()
        {
            string query = $"UPDATE `users` SET`Username`='{Username}',`Surname`='{Surname}',`OtherNames`='{OtherNames}',`Password`='{Password}',`IsActive`='{IsActive}',`IsAdmin`='{IsAdmin}' WHERE `Id`='{Id}'";
            return connection.Execute(query);
        }

        public static User getUserByUsername(string username)
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            try
            {
                return connection.QueryFirst<User>($"SELECT * FROM users where Username='{username}'");
            }
            catch (InvalidOperationException ex)
            {
                return null;
            }
        }

        public static List<User> GetAllUsers()
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            string query = "SELECT * FROM users";
            return connection.Query<User>(query).ToList();
        }

        public static int DeleteUser(User user)
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            string query = $"DELETE FROM users WHERE Id={user.Id}";
            return connection.Execute(query);
        }

        private byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        public bool Authenticate(string password)
        {
            return GetHashString(password) == Password;
        }
    }
}

