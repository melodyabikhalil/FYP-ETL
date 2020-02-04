using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FYP_ETL.Base
{
    class MySQLDatabase : Database
    {
        private MySqlConnection connection { get; set; }

        public MySQLDatabase(string serverName, string username, string password, string databaseName) :
            base(serverName, username, password, databaseName) {}

        public override bool Connect()
        {
            string connectionString = String.Format(
                "server={0};" + 
                "userid={1};" +
                "password={2};" + 
                "database={3};",
                this.serverName, this.username, this.password, this.databaseName);
            MySqlConnection connection = new MySqlConnection(connectionString);
            
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
            string query = "SHOW TABLES;";
            List<string> tablesNames = new List<string>();
            MySqlCommand command = new MySqlCommand(query, this.connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
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
