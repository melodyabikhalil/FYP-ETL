using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public override bool SetFieldsWithDetails(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            string tableNameInQuery = tableName;
            if (this.schema != "")
            {
                tableNameInQuery = this.schema + "." + tableName;
            }
                string query = @"SELECT 
                                c.name 'column_name',
                                t.Name 'data_type',
                                c.max_length 'max_length',
                                c.is_nullable,
                                ISNULL(i.is_primary_key, 0) 'is_pk'
                            FROM    
                                sys.columns c
                            INNER JOIN 
                                sys.types t ON c.user_type_id = t.user_type_id
                            LEFT OUTER JOIN 
                                sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id
                            LEFT OUTER JOIN 
                                sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id
                            WHERE
                                c.object_id = OBJECT_ID('" + tableNameInQuery + "');";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, this.connection);

                DataSet fieldsInfo = new DataSet();
                adapter.Fill(fieldsInfo, "Fields");

                table.fields = this.ParseFieldsDataTable(fieldsInfo.Tables[0]);
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
                int length = dataRow.Field<Int16>("max_length");
                bool isNullable = dataRow.Field<Boolean>("is_nullable");
                bool isPrimaryKey = dataRow.Field<Boolean>("is_pk");

                field = new Field(fieldName, type, length, isNullable, isPrimaryKey);
                fields.Add(field);
            }
            return fields;
        }

        public override bool SelectAll(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            string tableNameInQuery = tableName;
            if (this.schema != "")
            {
                tableNameInQuery = "[" + this.schema + "].[" + tableName + "]";
            }
            string query = "SELECT * FROM " + tableNameInQuery + ";";
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
    }
}
