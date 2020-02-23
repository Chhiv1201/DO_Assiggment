using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlCmdBuilder
{
    class SqlQueryBuilder
    {
        private readonly _ISqlCommandBuilder SqlBuilder;
        public SqlQueryBuilder(_ISqlCommandBuilder Sqlbuilder)
        {
            SqlBuilder = Sqlbuilder;
        }

        public SqlQueryBuilder Table(string table)
        {
            SqlBuilder.SetTable(table);

            return this;
        }
        public SqlQueryBuilder Fields(params string[] fields)
        {

            SqlBuilder.SetFields(fields);

            return this;
        }
        public SqlQueryBuilder Where(params string[] condition)
        {

            SqlBuilder.SetConditions(condition);
            return this;
        }

        public string GetQueryString()
        {
            return SqlBuilder.GetQueryString();
        }
    }
}
