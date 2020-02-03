using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_ETL.Base
{
    abstract class Field
    {
        public string fieldName;
        public string type;
        public int length;
        public bool canBeNull;
        public bool isPrimaryKey;
    }
}
