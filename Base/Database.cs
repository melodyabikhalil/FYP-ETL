using System.Collections.Generic;
using System.Data;

namespace FYP_ETL.Base
{
    abstract class Database
    {
        public string username { get; set; }
        public string password { get; set; }
        public string serverName { get; set; }
        public string databaseName { get; set; }
        public List<Table> tables { get; set; }

        public Database(string serverName, string username, string password, string databaseName)
        {
            this.serverName = serverName;
            this.username = username;
            this.password = password;
            this.databaseName = databaseName;
        }

        public int GetTableIndexByName(string tableName)
        {
            for (int i = 0; i < tables.Count; ++i)
            {
                if (tables[i].tableName == tableName)
                {
                    return i;
                }
            }
            return -1;
        }

        public void CreateTables(List<string> tablesNames)
        {
            Table table;
            for (int i = 0; i < tablesNames.Count; ++i)
            {
                table = new Table();
                table.tableName = tablesNames[i];
                this.tables.Add(table);
            }
        }

        abstract public List<string> GetTablesNames();
        abstract public void GetFieldsWithDetails(string tableName);
        abstract public bool Connect();
        abstract public bool Close();
        abstract public void insert(string tableName);
        abstract public void selectAll(string tableName);
        abstract public void update(DataTable dataTable);
        abstract public void delete(DataTable dataTable);
    }
}
