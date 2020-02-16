using FYP_ETL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_ETL
{
    static class Global
    {
        private static List<Database> databasesSource = new List<Database>();
        private static List<Database> databasesDestination = new List<Database>();
        private static List<Table> tablesSourceExpanded = new List<Table>();

        public static List<Database> DatabasesSource
        {
            get { return databasesSource; }
            set { databasesSource = value; }
        }

        public static List<Database> DatabasesDestination
        {
            get { return databasesDestination; }
            set { databasesDestination = value; }
        }

        public static List<Table> TablesSourceExpanded
        {
            get { return tablesSourceExpanded; }
            set { tablesSourceExpanded = value; }
        }
    }
}
