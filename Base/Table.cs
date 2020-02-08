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
    }
}
