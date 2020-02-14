using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace FYP_ETL.Base
{
    class AccessDatabase : Database
    {
        private OleDbConnection connection { get; set; }
        public string path { get; set; }

        public AccessDatabase(string path, string serverName = null, string username = null, string password = null, string databaseName = null) :
            base(serverName, username, password, databaseName)
        {
            this.path = path;
        }

        public override bool Connect()
        {
            string connectionString = String.Format(
                "Provider=Microsoft.Jet.OLEDB.4.0;" +
                "Data Source={0};",
                this.path);

            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();
                this.connection = connection;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public override bool Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public override List<string> GetTablesNames()
        {
            string query = "SELECT MSysObjects.name FROM MSysObjects WHERE MSysObjects.type IN(1, 4, 6) AND MSysObjects.name NOT LIKE '~*' AND MSysObjects.name NOT LIKE 'MSys*' ORDER BY MSysObjects.name";
            List<string> tablesNames = new List<string>();
            OleDbCommand command = new OleDbCommand(query, this.connection);

            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tablesNames.Add(reader.GetString(0));
                }
                return tablesNames;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return tablesNames;
            }
        }
        public override bool SelectAll(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            string query = "select * from " + tableName;
            OleDbCommand selectCommand = new OleDbCommand(query, this.connection);
            dataAdapter.SelectCommand = selectCommand;

            try
            {
                dataAdapter.Fill(table.dataTable);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
       
        public override bool Insert(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            DataTable dataTable = table.dataTable;
            if (dataTable == null)
            {
                return false;
            }
            Dictionary<string, OleDbType> columnsWithTypes = HelperAccess.GetsColumnsWithTypes(dataTable.Columns);
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd;
            List<string> fieldsList = table.GetColumnsNames();
            string fieldsString = HelperAccess.CreateFieldsString(fieldsList);
            string valuesString = HelperAccess.CreateValuesString(fieldsList);
            cmd = new OleDbCommand("INSERT INTO " + tableName + fieldsString + " VALUES" + valuesString, this.connection);
            da.InsertCommand = cmd;

            try
            {
                HelperAccess.SetParametersForInsertQuery(columnsWithTypes, da);
                da.Update(dataTable);
                dataTable.AcceptChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
