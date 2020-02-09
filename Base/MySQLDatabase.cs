using MySql.Data.MySqlClient;
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
            this.connection = new MySqlConnection(connectionString);
            
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
        
        
        public  MySqlDataAdapter CreateAdapter(MySqlConnection conn, string tableName)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd;
            

            // Create the SelectCommand.
            cmd = new MySqlCommand("SELECT * FROM "+ tableName , conn);
            
            da.SelectCommand = cmd;

            // Create the InsertCommand.
            List<string> fieldsList;
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            fieldsList = table.GetFieldsNames();
            string fieldsString = HelperMySQL.CreateFieldsString(fieldsList);
            string valuesString = HelperMySQL.CreateValuesString(fieldsList);
            cmd = new MySqlCommand("INSERT INTO "+ tableName + fieldsString +" VALUES" + valuesString , conn);
            


            da.InsertCommand = cmd;

            return da;
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
        public override bool SelectAll(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            string query  = "SELECT * FROM " + tableName + ";";
            MySqlDataAdapter da = this.CreateAdapter(this.connection, "users");
            
            
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

        public override bool SetFieldsWithDetails(string tableName)
        {
            Table table = this.tables[this.GetTableIndexByName(tableName)];
            if (table == null)
            {
                return false;
            }
            string query = "DESCRIBE " + tableName + ";";
            MySqlCommand cmd = new MySqlCommand(query, this.connection);
            try
            {
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                table.fields = this.ParseFieldsDataTable(dataSet.Tables[0]);
                foreach(Field field in table.fields)
                {
                    if (field.isPrimaryKey)
                    {
                        table.primaryKeyName = field.fieldName;
                        break;
                    }
                }
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
                string fieldName = dataRow.Field<string>("Field");
                string type = dataRow.Field<string>("Type");
                string isNullableString = dataRow.Field<string>("NULL");
                string isPrimaryKey = dataRow.Field<string>("Key");
                bool canBeNull = false;
                bool isPrimKey = false;
                if(isPrimaryKey == "PRI")
                {
                    isPrimKey = true;

                }
                if (isNullableString == "YES")
                {
                    canBeNull = true;
                }
                field = new Field(fieldName, type, null, canBeNull, isPrimKey);
                
                fields.Add(field);
            }
            return fields;
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
            MySqlDataAdapter da = this.CreateAdapter(this.connection, "users");
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
    }
}
