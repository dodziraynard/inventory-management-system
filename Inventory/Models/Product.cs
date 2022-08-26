using Dapper;
using Inventory.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public int Quantity { set; get; }
        public int CategoryId { set; get; }

        private MySqlConnection connection;

        public Product()
        {
            connection = new DBConnection().GetConnection();
        }
        public Product(string name, decimal price, int quantity, int categoryId)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            CategoryId = categoryId;

            connection = new DBConnection().GetConnection();
        }

        public int insertProduct()
        {
            string query = 
                $"INSERT INTO products (Name, Price,Quantity,CategoryId) VALUES('{this.Name}','{this.Price}','{this.Quantity}','{this.CategoryId}')";
            return connection.Execute(query);
        }

        public int updateProduct()
        {
            string query = $"UPDATE `products` SET `Name`='{this.Name}',`Price`='{this.Price}',`Quantity`='{this.Quantity}',`CategoryId`='{this.CategoryId}' WHERE `Id`={this.Id}";
            return connection.Execute(query);
        }

        public static Product getProductById(int id)
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            try
            {
                return connection.QueryFirst<Product>($"SELECT * FROM products where Id='{id}'");
            }
            catch (InvalidOperationException ex)
            {
                return null;
            }
        }

        public static List<Product> GetAllProducts()
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            string query = "SELECT * FROM products";
            return connection.Query<Product>(query).ToList();
        }

        public static int DeleteProduct(Product product)
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            string query = $"DELETE FROM products WHERE Id={product.Id}";
            return connection.Execute(query);
        }
    }
}

