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
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
            fillChart();

            titleBar.OnReload += reloadDashboard;
        }

        private void reloadDashboard()
        {
            MessageBox.Show("Reloaded Dashboard");
        }

        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            salesChart.Series["Sales"].Points.AddXY("Monday", "100");
            salesChart.Series["Sales"].Points.AddXY("Tuesday", "800");
            salesChart.Series["Sales"].Points.AddXY("Wednesday", "700");
            salesChart.Series["Sales"].Points.AddXY("Thursda", "10");
            salesChart.Series["Sales"].Points.AddXY("Friday", "150");
            salesChart.Series["Sales"].Points.AddXY("Saturday", "40");
            salesChart.Series["Sales"].Points.AddXY("Sunday", "70");
            //chart title  
            salesChart.Titles.Add("Sales History");
        }
    }
}
