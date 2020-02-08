using Npgsql;
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

        public override bool SelectAll(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            string query = "SELECT * FROM public.\"" + tableName + "\";";
            //string query = "SELECT * FROM " + tableName + ";";
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
            List<string> listDataTable =
                dataTable.Select()
                    .Select(dr => "(" + string.Join(",", dr.ItemArray.Select(x => string.Format("\'{0}\'", x))) + ")")
                    .ToList();
            string values = string.Join(",", listDataTable);
            //string query = "INSERT INTO public.\"" + tableName + "\" VALUES " + values + ";";
            string query = "INSERT INTO " + tableName + " VALUES " + values + ";";

            try
            {
                NpgsqlCommand command = new NpgsqlCommand(query, this.connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public override bool SetFieldsWithDetails(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            string query = "SELECT column_name,data_type,character_maximum_length,is_nullable FROM information_schema.columns where table_name = " + tableName + ";";
            NpgsqlCommand command = new NpgsqlCommand(query, this.connection);

            try
            {
                command.Prepare();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                table.fields = this.ParseFieldsDataTable(dataSet.Tables[0]);
                this.SetPrimaryKeyField(tableName);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        private List<Field> ParseFieldsDataTable(DataTable datatable)
        {
            List<Field> fields = new List<Field>();
            Field field;
            foreach (DataRow dataRow in datatable.Rows)
            {
                string fieldName = dataRow.Field<string>("column_name");
                string type = dataRow.Field<string>("data_type");
                int length = dataRow.Field<int>("character_maximum_length");
                string isNullableString = dataRow.Field<string>("is_nullable");
                bool canBeNull = false;
                if (isNullableString == "YES")
                {
                    canBeNull = true;
                }
                field = new Field(fieldName, type, length, canBeNull);
            }
            return fields;
        }

        private string GetPrimaryKeyName(string tableName)
        {
            string query = "SELECT a.attname "
                            + "FROM pg_index i "
                            + "JOIN   pg_attribute a ON a.attrelid = i.indrelid "
                            + "AND a.attnum = ANY(i.indkey) "
                            + "WHERE i.indrelid = 'public.\"" + tableName + "\"'::regclass "
                            + "AND i.indisprimary;";
            NpgsqlCommand command = new NpgsqlCommand(query, this.connection);

            try
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                string primaryKeyName = "";
                while (reader.Read())
                {
                    primaryKeyName = reader.GetString(0);
                }
                return primaryKeyName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void SetPrimaryKeyField(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return;
            }
            string primaryKeyName = this.GetPrimaryKeyName(tableName);
            table.primaryKeyName = primaryKeyName;
            foreach (Field field in table.fields)
            {
                if (field.fieldName == primaryKeyName)
                {
                    field.isPrimaryKey = true;
                    return;
                }
            }
        }
    }
}
