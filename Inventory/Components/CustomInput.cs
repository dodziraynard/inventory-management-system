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
    public partial class CustomInput : UserControl
    {
        [Browsable(true)]
        public string Label { get { return label.Text; } set { label.Text = value; } }
        public string Value { get { return inputBox.Text; } set { inputBox.Text = value; } }

        public CustomInput()
        {
            InitializeComponent();
        }
    }
}
