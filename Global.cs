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
        private static Table tableDestinationExpanded = new Table();

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

        public static Table TableDestinationExpanded
        {
            get { return tableDestinationExpanded; }
            set { tableDestinationExpanded = value; }
        }

        public static Database GetSourceDatabaseByName(string databaseName)
        {
            foreach(Database database in databasesSource)
            {
                if (database.databaseName == databaseName)
                {
                    return database;
                }
            }
            return null;
        }

        public static Database GetDestinationDatabaseByName(string databaseName)
        {
            foreach (Database database in databasesDestination)
            {
                if (database.databaseName == databaseName)
                {
                    return database;
                }
            }
            return null;
        }

        public static bool TableSourceAlreadyExpanded(Table table)
        {
            foreach (Table tableExpanded in TablesSourceExpanded)
            {
                if  (table == tableExpanded)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetTableSourceExpandedIndex(Table table)
        {
            for (int i = 0; i < tablesSourceExpanded.Count; ++i)
            {
                if (table == tablesSourceExpanded[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static void RemoveTable(bool isSource, string tableName)
        {
            if (isSource)
            {
                tablesSourceExpanded.Remove(GetSourceTableByName(tableName));
            }
        }

        public static Table GetSourceTableByName(string tableName)
        {
            foreach (Table table in tablesSourceExpanded)
            {
                if (table.tableName == tableName)
                {
                    return table;
                }
            }
            return null;
        }
    }
}
