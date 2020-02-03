using System.Collections.Generic;

namespace FYP_ETL.Base
{
    abstract class Table
    {
        private string tableName { get; set; }
        private int numberOfFields { get; set; }
        private List<Field> fields { get; set; }

        abstract public void GetFieldsNames();
        abstract public void Select(int initialRow, int endRow);
        abstract public bool Insert();
        abstract public bool Update();
        abstract public bool Delete();
    }
}
