using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FYP_ETL.Base
{
    abstract class Database
    {
        public String username;
        public String password;
        public String serverName;
        public String databaseName;
        public List<Table> tables;

        abstract public bool Connect();
        abstract public List<Table> getTablesNames();
        
        



    }
}
