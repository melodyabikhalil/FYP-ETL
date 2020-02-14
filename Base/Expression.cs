using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FYP_ETL.Base
{
    class Expression
    {
        DataTable expressionDt;
        DataTable mapDt;
        Expression instance;

        public static string Replace(string expression, DataRow row)   
        {
            string result = expression;
            foreach(DataColumn col in row.Table.Columns)
            {
                result = result.Replace(row[col].ToString(), col.ColumnName);
            }
            return result;
        }

        public static string Regexp(string expression, DataRow row, string regexColumnName)
        {
            Regex rg = new Regex(expression);
            Match match = rg.Match(row[regexColumnName].ToString());
            if (match.Success)
            {
                return match.Value;
            }
            return null;
        }
        public static string GetValue(DataRow expRow, DataRow row, DataColumn col, DataTable mapDt)
        {
            string value = "";
            string type = expRow["ExpressionType"].ToString();
            if (type == "Replace")
            {
                value = Replace(expRow["Expression"].ToString(), row);
            }
            if(type == "Reg")
            {
                value = Regexp(expRow["Expression"].ToString(), row, expRow["RegexpColumnName"].ToString());
            }
            if(type == "Map")
            {
                string sectionName = expRow["SectionName"].ToString();
                string fromValue = row[col].ToString();
                DataRow [] mapRows = mapDt.Select("Section = '" + sectionName + "' AND FromValue = '" + fromValue + "'");
                value = mapRows[0]["ToValue"].ToString();
            }
            return value;
           
        }
        private Expression()
        {
            //we have to construct the datatables expressionDt and mapDt
            expressionDt.Columns.Add("TableNameDest");
            expressionDt.Columns.Add("ColumnDest");
            expressionDt.Columns.Add("ExpressionType");
            expressionDt.Columns.Add("RegexpColumnName");
            expressionDt.Columns.Add("Expression", Type.GetType("System.String"));
            expressionDt.Columns.Add("SectionName");
            mapDt.Columns.Add("Section");
            mapDt.Columns.Add("FromValue");
            mapDt.Columns.Add("ToValue");
        }
        public Expression getInstance()
        {
            //lazy initialization
            if(this.instance == null)
            {
                this.instance = new Expression();
            }
            return this.instance;
        }
    }
}
