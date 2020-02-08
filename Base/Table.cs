using System;
using System.Collections.Generic;
using System.Data;

namespace FYP_ETL.Base
{
    class Table
    {
        public string tableName { get; set; }
        public int numberOfFields { get; set; }
        public List<Field> fields { get; set; }
        public DataTable dataTable { get; set; }
        public string primaryKey { get; set; }

        public Table()
        {
            this.fields = new List<Field>();
            this.dataTable = new DataTable();
        }

        public List<string> GetFieldsNames()
        {
            List<string> fieldsNames = new List<string>();
            for (int i = 0; i < fields.Count; ++i)
            {
                fieldsNames.Add(fields[i].fieldName);
            }
            return fieldsNames;
        }

        public string SelectValue(string fieldName, string primaryKeyValue)
        {
            string expression = this.primaryKey + " = " + primaryKeyValue;
            DataRow[] result = this.dataTable.Select(expression);
            if (result.Length != 1)
            {
                return null;
            }
            return (string)result[0][fieldName];
        }

        public static DataTable JoinDataTables(DataTable t1, DataTable t2, params Func<DataRow, DataRow, bool>[] joinOn)
        {
            DataTable result = new DataTable();
            foreach (DataColumn col in t1.Columns)
            {
                if (result.Columns[col.ColumnName] == null)
                    result.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataColumn col in t2.Columns)
            {
                if (result.Columns[col.ColumnName] == null)
                    result.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row1 in t1.Rows)
            {
                var joinRows = t2.AsEnumerable().Where(row2 =>
                {
                    foreach (var parameter in joinOn)
                    {
                        if (!parameter(row1, row2)) return false;
                    }
                    return true;
                });
                foreach (DataRow fromRow in joinRows)
                {
                    DataRow insertRow = result.NewRow();
                    foreach (DataColumn col1 in t1.Columns)
                    {
                        insertRow[col1.ColumnName] = row1[col1.ColumnName];
                    }
                    foreach (DataColumn col2 in t2.Columns)
                    {
                        insertRow[col2.ColumnName] = fromRow[col2.ColumnName];
                    }
                    result.Rows.Add(insertRow);
                }
            }
            return result;
        }
    }
}
