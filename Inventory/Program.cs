using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Models;

namespace Inventory
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            User hrd = new User("Raynard", "sompass");
            Console.WriteLine(hrd.Username);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
