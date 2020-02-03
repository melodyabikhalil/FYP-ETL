using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FYP_ETL.Base
{
    abstract class Table
    {
        public string tableName;
        public int numberOfFields;
        public List<Field> fields;
        abstract public List<Field> getFields();
        abstract public List<Field> Select(int initialRow, int endRow);
        abstract public bool Insert(List<Field> fields);
    }
}
