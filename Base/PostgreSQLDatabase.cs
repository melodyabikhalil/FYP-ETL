using Npgsql;
using System;
using System.Collections.Generic;

namespace FYP_ETL.Base
{
    class PostgreSQLDatabase : Database
    {
        private NpgsqlConnection connection { get; set; }
        public string port { get; set; }

        public PostgreSQLDatabase(string serverName, string username, string password, string databaseName, string port) :
            base(serverName, username, password, databaseName)
        {
            this.port = port;
        }

        public override bool Connect()
        {
            string connectionString = String.Format(
                "Server={0};" +
                "Port={1};" +
                "User Id={2};" +
                "Password={3};" +
                "Database={4};",
                 this.serverName, this.port, this.username, this.password, this.databaseName);
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
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
            string query = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE';";
            List<string> tablesNames = new List<string>();
            NpgsqlCommand command = new NpgsqlCommand(query, this.connection);
            try
            {
                NpgsqlDataReader reader = command.ExecuteReader();
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
