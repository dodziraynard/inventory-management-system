using System;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Inventory.Models;
using MySql.Data.MySqlClient;

namespace Inventory.Utils
{
    public class DBConnection
    {
        private MySqlConnection connection;
        public DBConnection()
        {
        }
        
        public MySqlConnection GetConnection()
        {
            string myConnectionString = "server=localhost;uid=root;" + "pwd=;database=inventory";
            if (connection == null)
            {
                try
                {
                    connection = new MySqlConnection();
                    connection.ConnectionString = myConnectionString;
                    return connection;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }
    }
}

