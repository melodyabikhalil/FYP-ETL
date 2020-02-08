using FYP_ETL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_ETL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            Database mysqldb = new MySQLDatabase("localhost", "root","mysql1234","fyp");
            Console.WriteLine(mysqldb);
            List<string> tablesNames = new List<string>();
            tablesNames.Add("users");
            mysqldb.CreateTablesList(tablesNames);
            mysqldb.Connect();
            mysqldb.SelectAll("users");
            int index = mysqldb.GetTableIndexByName("users");
            Table table = mysqldb.tables[index];
            Console.WriteLine(table);
            foreach (DataRow dataRow in table.dataTable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            mysqldb.Close();



        }
    }
}
