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
            string connectionString = @"server=" + this.serverName + ";userid=" + this.username + ";password=" + this.password + ";database=" + this.databaseName + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            try
            {
                connection.Open();
                this.connection = connection;
                return true;
            }
            catch (MySqlException e)
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
            catch (MySqlException e)
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
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return tablesNames;
            }
        }
    }
}
