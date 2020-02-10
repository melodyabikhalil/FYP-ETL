﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace FYP_ETL.Base
{
    class HelperAccess
    {
        public static OleDbType MapCsharpTypeToAccessType(Type dataType)
        {
            //by default hatayta bigint
            OleDbType olelDbType = OleDbType.BigInt;

            if (dataType == Type.GetType("System.Int32"))
            {
                olelDbType = OleDbType.BigInt;
            }
            else if (dataType == Type.GetType("System.String"))
            {
                olelDbType = OleDbType.VarChar;
            }
            else if (dataType == Type.GetType("System.Boolean"))
            {
                olelDbType = OleDbType.Boolean;
            }
            else if (dataType == Type.GetType("System.TimeSpan"))
            {
                olelDbType = OleDbType.DBTime;
            }
            else if (dataType == Type.GetType("System.Int16"))
            {
                olelDbType = OleDbType.SmallInt;
            }
            else if (dataType == Type.GetType("System.Double"))
            {
                olelDbType = OleDbType.Double;
            }
            else if (dataType == Type.GetType("System.Char"))
            {
                olelDbType = OleDbType.Char;
            }
            else if (dataType == Type.GetType("System.DateTime"))
            {
                olelDbType = OleDbType.DBTimeStamp;
            }
            return olelDbType;
        }

        public static Dictionary<string, OleDbType> GetsColumnsWithTypes(DataColumnCollection columns)
        {
            Dictionary<string, OleDbType> columnsWithTypes = new Dictionary<string, OleDbType>();
            foreach (DataColumn col in columns)
            {
                OleDbType type = HelperAccess.MapCsharpTypeToAccessType(col.DataType);
                columnsWithTypes.Add(col.ColumnName, type);
            }
            return columnsWithTypes;
        }

        public static string CreateFieldsString(List<string> fieldsList)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            foreach (string field in fieldsList)
            {
                sb.Append(field);
                sb.Append(",");
            }
            sb.Length--;
            sb.Append(")");
            Console.WriteLine(sb.ToString());
            return sb.ToString();

        }

        public static string CreateValuesString(List<string> fieldsList)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            foreach (string field in fieldsList)
            {
                
                sb.Append("?");
                sb.Append(",");
            }
            sb.Length--;
            sb.Append(")");
            return sb.ToString();

        }

        public static void SetParametersForInsertQuery(Dictionary<string, OleDbType> columnsWithTypes, OleDbDataAdapter dataAdapter)
        {
            int index = 0;
            foreach (KeyValuePair<string, OleDbType> column in columnsWithTypes)
            {
                dataAdapter.InsertCommand.Parameters.Add(new OleDbParameter(column.Key, column.Value));
                dataAdapter.InsertCommand.Parameters[index].Direction = ParameterDirection.Input;
                dataAdapter.InsertCommand.Parameters[index].SourceColumn = column.Key;
                index++;
            }
        }
    }
}
