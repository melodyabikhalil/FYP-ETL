
namespace FYP_ETL.Base
{
    class Field
    {
        private string fieldName { get; set; }
        private string type { get; set; }
        private int length { get; set; }
        private bool canBeNull { get; set; }
        private bool isPrimaryKey { get; set; }

        public Field(string fieldName, string type, int length, bool canBeNull, bool isPrimaryKey)
        {
            this.fieldName = fieldName;
            this.type = type;
            this.length = length;
            this.canBeNull = canBeNull;
            this.isPrimaryKey = isPrimaryKey;
        }
    }
}
