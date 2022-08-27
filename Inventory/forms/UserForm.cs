using Inventory.Models;
using Inventory.Pages;
using System;
using System.Windows.Forms;

namespace Inventory.forms
{
    public partial class UserForm : Form
    {
        public User currentUser = null;

        public UserForm()
        {
            InitializeComponent();
            currentUser = UsersPage.instance?.currentUser;

            if (currentUser != null)
            {
                usernameInput.Value = currentUser.Username;
                surnameInput.Value = currentUser.Surname;
                otherNamesInput.Value = currentUser.OtherNames;
               
                isAdmin.Checked = currentUser.IsAdmin==1;
                isActive.Checked = currentUser.IsActive==1;
            }
            else
            {
                deleteButton.Visible = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string surname = surnameInput.Value;
            string username = usernameInput.Value;
            string otherNames = otherNamesInput.Value;
            string password = passwordInput.Value;
            int admin = isAdmin.Checked?1:0;
            int active = isActive.Checked?1:0;

            if (username.Equals("") || (currentUser == null && password.Equals("")))
            {
                MessageBox.Show("Username and password are required");
                return;
            }

            User user = new User(username,password,surname,otherNames,active,admin);
            int affectedRow = -1;
            if (currentUser != null)
            {
                user.Id = currentUser.Id;
                if (password == null)
                    user.Password = currentUser.Password;
                affectedRow = user.updateUser();
            }
            else
            {
                affectedRow= user.insertUser();
            }

            if (affectedRow > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Couldn't save user into the database");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                int affectedRows = User.DeleteUser(currentUser);
                if (affectedRows > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
