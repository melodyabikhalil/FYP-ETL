using FYP_ETL.Base;
using System;
using System.Collections.Generic;
using System.Data;
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
        private static string joinQuery = "";
        private static DataTable joinDatatable = SetJoinDatatableSchema();
        private static Database databaseSourceExpanded = null;
        private static Database databaseDestinationExpanded = null;
        private static Table joinResultSourceTable = new Table();

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

        public static string JoinQuery
        {
            get { return joinQuery; }
            set { joinQuery = value; }
        }

        public static DataTable JoinDatatable
        {
            get { return joinDatatable; }
            set { joinDatatable = value; }
        }

        public static Database DatabaseSourceExpanded
        {
            get { return databaseSourceExpanded; }
            set { databaseSourceExpanded = value; }
        }

        public static Database DatabaseDestinationExpanded
        {
            get { return databaseDestinationExpanded; }
            set { databaseDestinationExpanded = value; }
        }

        public static Table JoinResultSourceTable
        {
            get { return joinResultSourceTable; }
            set { joinResultSourceTable = value; }
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
            else
            {
                tableDestinationExpanded = new Table();
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

        public static bool CanExpandTable(Table table)
        {
            if (DatabaseSourceExpanded == null)
            {
                return true;
            }
            foreach(Table dbTable in DatabaseSourceExpanded.tables)
            {
                if (table == dbTable)
                {
                    return true;
                }
            }
            return false;
        }

        private static DataTable SetJoinDatatableSchema()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Database");
            dataTable.Columns.Add("Table1");
            dataTable.Columns.Add("Table2");
            dataTable.Columns.Add("FieldTable1");
            dataTable.Columns.Add("FieldTable2");
            return dataTable;
        }

        public static string GetJoinQuery(List<Tuple<Dictionary<string, string>, Dictionary<string, string>>> tablesAndColumnsToJoinOn)
        {
            string query = "";
            if (tablesAndColumnsToJoinOn.Count > 0)
            {
                query = "SELECT * FROM ";
                string table1 = "";
                string column1 = "";
                string table2 = "";
                string column2 = "";

                for (int i = 0; i < tablesAndColumnsToJoinOn.Count; ++i)
                {
                    Tuple < Dictionary<string, string>, Dictionary<string, string>> tuple = tablesAndColumnsToJoinOn[i];
                    table1 = tuple.Item1["table"];
                    column1 = tuple.Item1["column"];
                    table2 = tuple.Item2["table"];
                    column2 = tuple.Item2["column"];

                    if (i == 0)
                    {
                        query += table1;
                    }
                    query += " JOIN " + table2 + " ON " + table1 + "." + column1 + "=" + table2 + "." + column2;
                }
                query += ";";
            }
            return query;
        }

        public static bool CreateJoinTable(List<Tuple<Dictionary<string, string>, Dictionary<string, string>>> tablesAndColumnsToJoinOn)
        {
            string query = GetJoinQuery(tablesAndColumnsToJoinOn);
            bool result = false;
            if (DatabaseSourceExpanded != null && TablesSourceExpanded.Count > 0)
            {
                Table table = new Table();
                string tableName = "source_table";
                table.tableName = tableName;
                DatabaseSourceExpanded.tables.Add(table);
                result = DatabaseSourceExpanded.Select(tableName, query);
                table.SetColumnsFromDatatable();
                JoinResultSourceTable = table;
            }
            return result;
        }
    }
}
