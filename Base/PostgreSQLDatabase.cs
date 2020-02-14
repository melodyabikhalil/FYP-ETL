﻿using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FYP_ETL.Base
{
    class PostgreSQLDatabase : Database
    {
        private NpgsqlConnection connection { get; set; }
        public string port { get; set; }
        public string schema { get; set; }

        public PostgreSQLDatabase(string serverName, string username, string password, string databaseName, string port, string schema = "") :
            base(serverName, username, password, databaseName)
        {
            this.port = port;
            this.schema = schema;
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
            string query = "SELECT table_name FROM information_schema.tables AND table_type = 'BASE TABLE';";
            if (this.schema != "")
            {
                query = "SELECT table_name FROM information_schema.tables WHERE table_schema = '" + this.schema + "' AND table_type = 'BASE TABLE';";
            }
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

        public override bool SelectAll(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            string query = "SELECT * FROM \"" + tableName + "\";";
            if (this.schema != "")
            {
                query = "SELECT * FROM " + this.schema + ".\"" + tableName + "\";";
            }
            NpgsqlCommand command = new NpgsqlCommand(query, this.connection);

            try
            {
                command.Prepare();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

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
            Dictionary<string, NpgsqlDbType> columnsWithTypes = HelperPostgreSQL.GetsColumnsWithTypes(dataTable.Columns);
            string values = HelperPostgreSQL.GetValuesStringForInsertQuery(dataTable.Columns);


            string selectQuery = "SELECT * FROM \"" + tableName + "\"";
            string insertQuery = "INSERT INTO \"" + tableName + "\"" + fields + " values " + values;
            if (this.schema != "")
            {
                selectQuery = "SELECT * FROM " + this.schema + ".\"" + tableName + "\"";
                insertQuery = "INSERT INTO " + this.schema + ".\"" + tableName + "\"" + fields + " values " + values;
            }

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(selectQuery, connection);
                dataAdapter.InsertCommand = new NpgsqlCommand(insertQuery, connection);
                HelperPostgreSQL.SetParametersForInsertQuery(columnsWithTypes, dataAdapter);

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
    }
}
