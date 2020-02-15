﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using System.Text;

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
            try
            {
                this.connection = new MySqlConnection(connectionString);
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

        public override bool Select(string tableName, string query)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }

            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd;
            // Create the SelectCommand.
            cmd = new MySqlCommand(query, this.connection);
            da.SelectCommand = cmd;
            try
            {
                da.Fill(table.dataTable);
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
            Dictionary<string, MySqlDbType> columnsWithTypes = HelperMySQL.GetsColumnsWithTypes(dataTable.Columns);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd;
            List<string> fieldsList = table.GetColumnsNames();
            string fieldsString = HelperMySQL.CreateFieldsString(fieldsList);
            string valuesString = HelperMySQL.CreateValuesString(fieldsList);
            cmd = new MySqlCommand("INSERT INTO " + tableName + fieldsString + " VALUES" + valuesString, this.connection);
            da.InsertCommand = cmd;

            try
            {
                HelperMySQL.SetParametersForInsertQuery(columnsWithTypes, da);
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

        public override bool SetDatatableSchema(string tableName)
        {
            string query = "SELECT * FROM " + tableName + " WHERE 1=0;";
            return this.Select(tableName, query);
        }
        public override bool Equals(Object obj)
        {
            return (obj is MySQLDatabase) 
                && ((MySQLDatabase)obj).databaseName == this.databaseName
                 && ((MySQLDatabase)obj).username == this.username
                  && ((MySQLDatabase)obj).password == this.password
                   && ((MySQLDatabase)obj).serverName == this.serverName;
        }
    }
}
