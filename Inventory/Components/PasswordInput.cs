using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Components
{
    public partial class PasswordInput : UserControl
    {
        [Browsable(true)]
        public bool ShowPassword {
            get { return !inputBox.UseSystemPasswordChar; }
            set { inputBox.UseSystemPasswordChar=!value; }
        }
        public string Label { get { return label.Text; } set { label.Text = value; } }
        public string Value { get { return inputBox.Text; } set { inputBox.Text = value; } }

        public PasswordInput()
        {
            InitializeComponent();
            ShowPassword = false;
            inputBox.UseSystemPasswordChar = !ShowPassword;
            label.Text = Label ?? "Password";
        }

        private void hideShowButon_Click(object sender, EventArgs e)
        {
            ShowPassword = !ShowPassword;
            inputBox.UseSystemPasswordChar = !ShowPassword;
            string info = ShowPassword ? "Hide" : "Show";
            hideShowButon.Text = info;
        }

        private void PasswordInput_Validated(object sender, EventArgs e)
        {
            label.Text = Label ?? "Password";

        }
    }
}
