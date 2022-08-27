using Dapper;
using Inventory.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }

        private MySqlConnection connection;

        public Category()
        { }

        public Category(string name)
        {
            Name = name;
            connection = new DBConnection().GetConnection();
        }

        public int insertCategory()
        {
            string query = 
                $"INSERT INTO categories (Name) VALUES('{Name}')";
            return connection.Execute(query);
        }

        public int updateCategory()
        {
            string query = $"UPDATE `categories` SET `Name`='{this.Name}' WHERE `Id`={this.Id}";
            return connection.Execute(query);
        }

        public static Category getCategoryById(int id)
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            try
            {
                return connection.QueryFirst<Category>($"SELECT * FROM categories where Id='{id}'");
            }
            catch (InvalidOperationException ex)
            {
                return null;
            }
        }

        public static List<Category> GetAllCategories()
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            string query = "SELECT * FROM categories";
            return connection.Query<Category>(query).ToList();
        }

        public static int DeleteCategory(Category category)
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            string query = $"DELETE FROM categories WHERE Id={category.Id}";
            return connection.Execute(query);
        }
    }
}

