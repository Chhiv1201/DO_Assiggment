using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlCmdBuilder
{
    public class SqlInsert : _ISqlCommandBuilder
    {
        _SqlString SqlQueryString = new _SqlString();





        public SqlInsert()
        {
            SqlQueryString._action = _SqlAction.INSERT;
        }

        public string GetQueryString()
        {
            return SqlQueryString.GetCommand();
        }
        public List<string> GetConditions()
        {
            return SqlQueryString._conditions;
        }

        public List<string> GetFields()
        {
            return SqlQueryString._fields;
        }

        public string GetTable()
        {

            return SqlQueryString._tableName;
        }


        
        public void SetConditions(params string[] conditions)
        {
            SqlQueryString._conditions = conditions.ToList();
        }

        public void SetFields(params string[] fields)
        {
            SqlQueryString._fields = fields.ToList();
        }

        public void SetTable(string table)
        {
            SqlQueryString._tableName = table;
        }
    }
}
