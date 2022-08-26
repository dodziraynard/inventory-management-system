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
    public partial class TitleBar : UserControl
    {
        public delegate void ReloadHandler();

        public event ReloadHandler OnReload;

        public TitleBar()
        {
            InitializeComponent();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            OnReload?.Invoke();
        }

        public void SetTitle(string title)
        {
            this.titleText.Text = title;
        }

        public void SetInfoInfo(string text)
        {
            this.infoText.Text = text;
        }
    }
}
