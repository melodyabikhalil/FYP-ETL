using System.Collections.Generic;

namespace FYP_ETL.Base
{
    abstract class Database
    {
        private string username { get; set; }
        private string password { get; set; }
        private string serverName { get; set; }
        private string databaseName { get; set; }
        private List<Table> tables { get; set; }

        abstract public List<Table> GetTablesNames();
        abstract public bool Connect();
    }
}
