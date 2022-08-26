using Dapper;
using Inventory.Models;
using Inventory.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Login : Form
    {
        MySqlConnection connection;

        public Login()
        {
            InitializeComponent();
            connection = new DBConnection().GetConnection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            passwordInput.Text = "";
            usernameInput.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            connection.Open();
            try
            {
                var user = connection.QueryFirst<User>($"SELECT * FROM users where username='{username}'");
                if (user.Password == password)
                {
                    Hide();
                    MainScreen home = new MainScreen();
                    home.Show(this);
                }
            }
            catch (InvalidOperationException ex)
            {
               
            }
            errorMessageText.Text = "Invalid credentials.";
            connection.Close();
        }
    }
}
