using System;
using System.Collections.Generic;
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

        public override bool SetFieldsWithDetails(string tableName)
        {
            throw new NotImplementedException();
        }

        public override bool Insert(string tableName)
        {
            throw new NotImplementedException();
        }

        public override bool SelectAll(string tableName)
        {
            throw new NotImplementedException();
        }
    }
}
