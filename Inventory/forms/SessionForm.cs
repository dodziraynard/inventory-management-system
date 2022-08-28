using Inventory.Models;
using Inventory.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.forms
{
    public partial class SessionForm : Form
    {
        public Session currentSession = null;
        private List<User> users;

        public SessionForm()
        {
            InitializeComponent();
            currentSession = SessionsPage.instance?.currentSession;

            sessionStart.Format = DateTimePickerFormat.Custom;
            sessionStart.CustomFormat = "dd/MM/yyyy hh:mm tt";

            sessionEnd.Format = DateTimePickerFormat.Custom;
            sessionEnd.CustomFormat = "dd/MM/yyyy hh:mm tt";
            
            // Populate the user combo box.
            users = User.GetAllUsers();

            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                usernameInput.Items.Add(user.Username);
            }
            if (currentSession != null)
            {
                usernameInput.SelectedItem = currentSession.Username;
                sessionStart.Value = new DateTime(currentSession.Start);
                sessionEnd.Value = new DateTime(currentSession.End);
                customInput1.Value = currentSession.Name;
            }
            else
            {
                deleteButton.Visible = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            long end =  sessionEnd.Value.Ticks;
            long start =  sessionStart.Value.Ticks;
            string name = customInput1.Value;
            string username = usernameInput.SelectedItem.ToString();
            
            if (name.Equals("") || username.Equals(""))
            {
                MessageBox.Show("Please enter a valid name and username");
                return;
            }

            int affectedRow = -1;
            Session session = new Session(name, start, end, username);
            if (currentSession != null)
            {
                session.Id = currentSession.Id;
                affectedRow = session.updateSession();
            }
            else
            {
                affectedRow = session.insertSession();
            }
            if (affectedRow > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Couldn't save category into the database");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            if (currentSession != null)
            {
                int affectedRows = Session.DeleteSession(currentSession);
                if (affectedRows > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
