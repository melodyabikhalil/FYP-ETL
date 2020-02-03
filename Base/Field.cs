
namespace FYP_ETL.Base
{
    class Field
    {
        private string fieldName { get; set; }
        private string type { get; set; }
        private int length { get; set; }
        private bool canBeNull { get; set; }
        private bool isPrimaryKey { get; set; }
    }
}
