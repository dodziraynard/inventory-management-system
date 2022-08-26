using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Inventory.Models;
using Inventory.Utils;

namespace Inventory
{
    static class Program
    {
     
        [STAThread]
        static void Main()
        {
            User hrd = new User("Raynard", "sompass");
            Console.WriteLine(hrd.Username);

            DBConnection connection = new DBConnection();

            //var cs = @"Server=localhost\SQLEXPRESS;Database=inve;Trusted_Connection=True;";

            //var con = new SqlConnection(sqlConnectionString);
            //con.Open();

            //var cars = con.Query<User>("SELECT * FROM users").ToList();

            //cars.ForEach(car => Console.WriteLine(car));
            //Console.WriteLine("DONE");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
}
}
