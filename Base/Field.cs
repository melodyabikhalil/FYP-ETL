
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
    }
}
