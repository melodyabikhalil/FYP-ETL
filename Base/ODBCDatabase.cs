﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_ETL.Base
{
    class ODBCDatabase : Database
    {
        private OdbcConnection connection { get; set; }

        public string connectionString { get; set; }

        public ODBCDatabase(string connectionString, string serverName = null, string username = null, string password = null, string databaseName = null) :
            base(serverName, username, password, databaseName)
        {
            this.connectionString = connectionString;
        }

        public override bool Connect()
        {
            try
            {
                OdbcConnection connection = new OdbcConnection(this.connectionString);
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
            string query = "SELECT table_name FROM all_tables;";
            List<string> tablesNames = new List<string>();
            OdbcCommand command = new OdbcCommand(query, this.connection);
            try
            {
                OdbcDataReader reader = command.ExecuteReader();
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
            OdbcCommand command = new OdbcCommand(query, this.connection);

            try
            {
                command.Prepare();
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command);

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
            Dictionary<string, OdbcType> columnsWithTypes = HelperODBC.GetsColumnsWithTypes(dataTable.Columns);
            OdbcDataAdapter da = new OdbcDataAdapter();
            OdbcCommand cmd;
            List<string> fieldsList = table.GetColumnsNames();
            string fieldsString = HelperODBC.CreateFieldsString(fieldsList);
            string valuesString = HelperODBC.CreateValuesString(fieldsList);
            cmd = new OdbcCommand("INSERT INTO " + tableName+ " " + fieldsString + " VALUES " + valuesString, this.connection);
            da.InsertCommand = cmd;

            try
            {
                HelperODBC.SetParametersForInsertQuery(columnsWithTypes, da);
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
            string query = "select * from "+ tableName + " where 1=0;";
            bool result = this.Select(tableName, query);
            if (result)
            {
                this.GetTable(tableName).columns = this.GetTable(tableName).dataTable.Columns.Cast<DataColumn>().ToList();
            }
            return result;
        }

        public override bool Equals(Object obj)
        {
            return (obj is ODBCDatabase)
                && ((ODBCDatabase)obj).connectionString == this.connectionString;        
        }



    }
}
