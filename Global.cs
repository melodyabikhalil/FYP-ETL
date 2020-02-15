using FYP_ETL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_ETL
{
    static class Global
    {
        private static List<Database> databases = new List<Database>();

        public static List<Database> Databases
        {
            get { return databases; }
            set { databases = value; }
        }
    }
}
