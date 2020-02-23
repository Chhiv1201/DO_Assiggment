using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlCmdBuilder
{
    interface _ISqlCommandBuilder
    {
        //void SetAction(string action);
        //string GetAction();
        void SetTable(string table);
        string GetTable();

        void SetFields(params string []fields);
        List<string> GetFields();

        void SetConditions(params string[] conditions);
        List<string> GetConditions();

        string GetQueryString();
    }
}
