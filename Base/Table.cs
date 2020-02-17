﻿using System;
using System.Collections.Generic;
using System.Data;

namespace FYP_ETL.Base
{
    class Table
    {
        public string tableName { get; set; }
        public int numberOfFields { get; set; }
        public string primaryKeyName { get; set; }
        public List<DataColumn> columns { get; set; }
        public DataTable dataTable { get; set; }

        public Table()
        {
            this.columns = new List<DataColumn>();
            this.dataTable = new DataTable();
        }

        public List<string> GetColumnsNames()
        {
            List<string> columnsNames = new List<string>();
            for (int i = 0; i < columns.Count; ++i)
            {
                columnsNames.Add(columns[i].ColumnName);
            }
            return columnsNames;
        }

        public DataColumn GetColumnByName(string fieldName)
        {
            foreach (DataColumn column in this.columns)
            {
                if (column.ColumnName == fieldName)
                {
                    return column;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return String.Format("Name:{0}, Number of fields:{1}, Primary key:{2}", this.tableName, this.numberOfFields, this.primaryKeyName);
        }

        public override bool Equals(Object obj)
        {
            return (obj is Table)
                && ((Table)obj).tableName == this.tableName
                 && ((Table)obj).columns == this.columns;
        }
    }
}
