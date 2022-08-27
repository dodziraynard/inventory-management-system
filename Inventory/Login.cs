using Dapper;
using Inventory.Models;
using Inventory.Utils;
using MySql.Data.MySqlClient;
using System;
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
            User user = User.getUserByUsername(username);
            if(user != null && user.Authenticate(password) && user.IsActive==1)
            {
                Hide();
                MainScreen home = new MainScreen();
                home.Show(this);
            }
            errorMessageText.Text = "Invalid credentials.";
            connection.Close();
        }
    }
}
