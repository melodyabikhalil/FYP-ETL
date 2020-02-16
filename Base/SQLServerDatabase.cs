using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FYP_ETL.Base
{
    class SQLServerDatabase : Database
    {
        private SqlConnection connection { get; set; }
        public string schema { get; set; }
        public SQLServerDatabase(string serverName, string username, string password, string databaseName, string schema = "") :
            base(serverName, username, password, databaseName)
        {
            this.schema = schema;
        }

        public override bool Connect()
        {
            string connectionString = String.Format(
                "Data Source={0};" +
                "Initial Catalog={1};" +
                "User ID={2};" +
                "Password={3};",
                 this.serverName, this.databaseName, this.username, this.password);
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
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
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE';";
            List<string> tablesNames = new List<string>();

            try
            {
                SqlCommand command = new SqlCommand(query, this.connection);
                SqlDataReader reader = command.ExecuteReader();
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

        public override bool Select(string tableName, string query)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            SqlCommand command = new SqlCommand(query, this.connection);

            try
            {
                command.Prepare();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                table.dataTable = dataSet.Tables[0];
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

            List<string> fieldsNames = table.GetColumnsNames();
            string fields = "(" + string.Join(",", fieldsNames.Select(x => string.Format("\"{0}\"", x))) + ")";
            Dictionary<string, SqlDbType> columnsWithTypes = HelperSQLServer.GetsColumnsWithTypes(dataTable.Columns);
            string values = HelperSQLServer.GetValuesStringForInsertQuery(dataTable.Columns);

            string tableNameInQuery = tableName;
            if (this.schema != "")
            {
                tableNameInQuery = "[" + this.schema + "].[" + tableName + "]";
            }
            string insertQuery = "INSERT INTO "+ tableName + fields + " values " + values;

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(insertQuery, this.connection);
                HelperSQLServer.SetParametersForInsertQuery(columnsWithTypes, command, table);
                dataAdapter.InsertCommand = command;

                dataAdapter.Update(dataTable);
                dataTable.AcceptChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public override bool SetDatatableSchema(string tableName)
        {
            string query = "SELECT * FROM " + tableName + " WHERE 1=0;";
            bool result = this.Select(tableName, query);
            if (result)
            {
                this.GetTable(tableName).columns = this.GetTable(tableName).dataTable.Columns.Cast<DataColumn>().ToList();
            }
            return result;
        }
        public override bool Equals(Object obj)
        {
            return (obj is SQLServerDatabase)
                && ((SQLServerDatabase)obj).databaseName == this.databaseName
                 && ((SQLServerDatabase)obj).username == this.username
                  && ((SQLServerDatabase)obj).password == this.password
                   && ((SQLServerDatabase)obj).serverName == this.serverName;
        }
    }
}
