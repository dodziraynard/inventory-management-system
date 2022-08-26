using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory
{
    public partial class MainScreen : Form
    {
        Button CurrentButton;
        public MainScreen()
        {
            InitializeComponent();
        }
        private void changePage(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Tag == null)
                return;

            string name = button.Tag.ToString();
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.FromArgb(50,50,74);
            }
            foreach (Control item in mainPage.Controls)
            {
                if (item.Name.StartsWith("page"))
                {
                    if (item.Name.ToLower().Contains(name.ToLower()))
                    {
                        item.Visible = true;
                        button.BackColor = Color.FromArgb(70, 70, 94);
                        CurrentButton = button;
                    }
                    else
                    {
                        item.Visible = false;
                    }
                }
            }
        }
    }
}
