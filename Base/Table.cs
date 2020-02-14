using System;
using System.Collections.Generic;
using System.Data;

namespace FYP_ETL.Base
{
    class Table
    {
        public string tableName { get; set; }
        public int numberOfFields { get; set; }
        public string primaryKeyName { get; set; }
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

        public Field GetFieldByName(string fieldName)
        {
            foreach (Field field in this.fields)
            {
                if (field.fieldName == fieldName)
                {
                    return field;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return String.Format("Name:{0}, Number of fields:{1}, Primary key:{2}", this.tableName, this.numberOfFields, this.primaryKeyName);
        }
    }
}
