using Inventory.forms;
using Inventory.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory.Pages
{
    public partial class SessionsPage : UserControl
    {
        public Session currentSession = null;
        public static SessionsPage instance = null;
        private List<Session> sessions;
        private List<Session> allSessions;

        public SessionsPage()
        {
            InitializeComponent();
            titleBar.SetTitle("SESSION/TILL");
            titleBar.OnReload += reloadSessions;

            instance = this;
        }

        private void initTable()
        {
            dataGridView.Rows.Clear();
            //ADD COLUMNS
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "Name";
            dataGridView.Columns[1].Name = "Username";
            dataGridView.Columns[2].Name = "Start";
            dataGridView.Columns[3].Name = "End";
            dataGridView.Columns[4].Name = "Status";

            //ADD ROWS
            foreach (Session session in sessions)
            {
                ArrayList row = new ArrayList();
                row.Add(session.Name);
                row.Add(session.Username);
                row.Add(new DateTime(session.Start).ToLongDateString());
                row.Add(new DateTime(session.End).ToLongDateString());
                
                // Set session status.
                string status;
                if (DateTime.Now.Ticks > session.End)
                {
                    status = "Closed";
                } else if(DateTime.Now.Ticks > session.Start)
                {
                    status = "Open";
                }
                else
                {
                    status = "Inactive";
                }
                row.Add(status);
                dataGridView.Rows.Add(row.ToArray());
            }

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Edit";
            button.Text = "Edit";
            button.HeaderText = "Edit";
            button.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(button);
        }

        private void reloadSessions()
        {
            sessions = Session.GetAllSessions();
            allSessions = sessions;
            initTable();
        }

        private void addSessionButton_Click(object sender, EventArgs e)
        {
            currentSession = null;
            navigateToSessionFormPage();
        }

        private void navigateToSessionFormPage()
        {
            using (var form = new SessionForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    reloadSessions();
                }
            }
        }
        private void SessionsPage_Load(object sender, EventArgs e)
        {
            sessions = Session.GetAllSessions();
            allSessions = sessions;
            initTable();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                currentSession = sessions.ToArray()[(e.RowIndex)];
                navigateToSessionFormPage();
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string term = searchInput.Text?.ToLower();
            if (term.Equals(""))
            {
                sessions = allSessions;
            }
            else
            {
                List<Session> filtered = new List<Session>();
                foreach (Session session in allSessions)
                {
                    if (session.Name.ToLower().Contains(term))
                    {
                        filtered.Add(session);
                    }
                }
                sessions = filtered;
            }
            initTable();
        }
    }
}
