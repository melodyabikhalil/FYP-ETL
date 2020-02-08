
using System;

namespace FYP_ETL.Base
{
    class Field
    {
        public string fieldName { get; set; }
        public string type { get; set; }
        public int length { get; set; }
        public bool canBeNull { get; set; }
        public bool isPrimaryKey { get; set; }

        public Field(string fieldName, string type, int length, bool canBeNull, bool isPrimaryKey = false)
        {
            this.fieldName = fieldName;
            this.type = type;
            this.length = length;
            this.canBeNull = canBeNull;
            this.isPrimaryKey = isPrimaryKey;
        }
        public override string ToString()
        {
            return String.Format("Name:{0}, Type:{1}, Length:{2}, Can be null:{3}, Is primary key:{4}", this.fieldName, this.type, this.length, this.canBeNull, this.isPrimaryKey);
        }
    }
}
