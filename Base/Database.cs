using System.Collections.Generic;

namespace FYP_ETL.Base
{
    abstract class Database
    {
        protected string username { get; set; }
        protected string password { get; set; }
        protected string serverName { get; set; }
        protected string databaseName { get; set; }
        protected List<Table> tables { get; set; }

        protected Database(string serverName, string username, string password, string databaseName)
        {
            this.serverName = serverName;
            this.username = username;
            this.password = password;
            this.databaseName = databaseName;
        }

        abstract public List<string> GetTablesNames();
        abstract public bool Connect();
        abstract public bool Close();
    }
}
