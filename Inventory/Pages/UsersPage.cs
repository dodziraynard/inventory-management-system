using Inventory.forms;
using Inventory.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory.Pages
{
    public partial class UsersPage : UserControl
    {
        public User currentUser = null;
        public static UsersPage instance = null;
        private List<User> users;
        private List<User> allUsers;

        public UsersPage()
        {
            InitializeComponent();
            titleBar.SetTitle("USERS");
            titleBar.OnReload += reloadUsers;

            instance = this;
        }

        private void initTable()
        {
            dataGridView.Rows.Clear();
            //ADD COLUMNS
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "Username";
            dataGridView.Columns[1].Name = "Surname";
            dataGridView.Columns[2].Name = "Other Names";
            dataGridView.Columns[3].Name = "Status";
            dataGridView.Columns[4].Name = "Role";

            //ADD ROWS
            foreach (User user in users)
            {
                ArrayList row = new ArrayList();
                row.Add(user.Username);
                row.Add(user.Surname);
                row.Add(user.OtherNames);
                string status = user.IsActive==1 ? "Active" : "Not Active";
                string role = user.IsAdmin==1 ? "Admin" : "Attendant";
                row.Add(status);
                row.Add(role);
                dataGridView.Rows.Add(row.ToArray());
            }

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Edit";
            button.Text = "Edit";
            button.HeaderText = "Edit";
            button.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(button);
        }

        private void reloadUsers()
        {
            users = User.GetAllUsers();
            allUsers = users;
            initTable();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            currentUser = null;
            navigateToUserFormPage();
        }

        private void navigateToUserFormPage()
        {
            using (var form = new UserForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    reloadUsers();
                }
            }
        }
        private void UsersPage_Load(object sender, EventArgs e)
        {
            users = User.GetAllUsers();
            allUsers = users;
            initTable();
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                currentUser = users.ToArray()[(e.RowIndex)];
                navigateToUserFormPage();
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string term = searchInput.Text?.ToLower();
            if (term.Equals(""))
            {
                users = allUsers;
            }
            else
            {
                List<User> filtered = new List<User>();
                foreach (User user in allUsers)
                {
                    if ((user.Username + user.Surname + user.OtherNames).ToLower().Contains(term))
                    {
                        filtered.Add(user);
                    }
                }
                users = filtered;
            }
            initTable();
        }
    }
}
