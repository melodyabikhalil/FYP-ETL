using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FYP_ETL.Base
{
    class SQLServerDatabase : Database
    {
        private SqlConnection connection { get; set; }

        public SQLServerDatabase(string serverName, string username, string password, string databaseName) :
            base(serverName, username, password, databaseName) { }

        public override bool Connect()
        {
            string connectionString = String.Format(
                "Data Source={0};" +
                "Initial Catalog={1};" +
                "User ID={2};" +
                "Password={3};",
                 this.serverName, this.databaseName, this.username, this.password);
            SqlConnection connection = new SqlConnection(connectionString);
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
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE';";
            List<string> tablesNames = new List<string>();
            SqlCommand command = new SqlCommand(query, this.connection);
            try
            {
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

       
    }
}
