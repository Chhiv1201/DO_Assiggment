using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlCmdBuilder
{
    class _SqlString
    {
        string command = "";
        
        public _SqlAction _action { get; set; }

        public List<string> _fields = new List<string>();
        public string _tableName { get; set; }

        public List<string> _conditions = new List<string>();
 
        public _SqlString()
        {
            _fields = new List<string>();
            _conditions = new List<string>();
            command = "";
        }

        string FieldsAsString()
        {
            string result = "";
            foreach (var field in _fields)
            {
                if (field != "")
                {
                    result += ((field.Contains("*")?field:"["+field+"]")+ ", ");

                }
            }
            if (result != "")
            {
                int i = result.Length;
                result = result.Remove(result.Length-2);
            }
            return result;
        }

        string FieldsAsParamater()
        {
            string result = "";
            foreach (var field in _fields)
            {
                if (field != "")
                {
                    result += ("@" + field + ", ");
                }
            }
            if (result != "")
            {
                result = result.Remove(result.Length-2);
            }
            return result;
        }

        string FieldToUpdate()
        {
            string result = "";
            foreach (var field in _fields)
            {
                if (field != "")
                {
                    result += ("[" +field+"]" + " = @" + field + ", ");
                }
            }
            if (result != "")
            {
                result = result.Remove(result.Length-2);
            }
            return result;
        }

        string ConditionAsString()
        {
            string result = "";
            foreach (var cond in _conditions)
            {
                if (cond != "")
                {
                    result += (cond + "AND ");
                }
            }
            if (result != "")
            {
                result =" WHERE " + result.Remove(result.Count()-4);
            }
            return result;
        }

        public string GetCommand()
        {
            string cmd = "";

            if (_tableName != null)
            {
                switch (_action)
                {
                    case _SqlAction.Undefined:
                        throw new Exception("Action is Require!");

                    case _SqlAction.SELECT:
                        cmd = "SELECT " + FieldsAsString() + " FROM [" + _tableName + "] " + ConditionAsString();
                        break;
                    case _SqlAction.INSERT:
                        cmd = "INSERT" + " INTO [" + _tableName + "](" + FieldsAsString() + ") VALUES(" + FieldsAsParamater() + ")" + ConditionAsString();
                        break;
                    case _SqlAction.UPDATE:
                        cmd = "UPDATE [" + _tableName + "] SET " + FieldToUpdate() + ConditionAsString();
                        break;
                    case _SqlAction.DELETE:
                        cmd = "DELETE FROM [" + _tableName+"]" + ConditionAsString();
                        break;
                }
            }
            else
            {
                throw new Exception("Tabel Name is Require!");
            }
            command = cmd;
            return command;
        }
    }

    public enum _SqlAction
    {
        Undefined=0,
        SELECT = 1,
        INSERT = 2,
        UPDATE = 3,
        DELETE = 4
    }

    //public enum _SqlConjunction
    //{
    //    FROM = 1,
    //    IN_TO = 2,
    //    WHERE = 3,
    //    AND = 4,
    //    VALUES = 5
    //}
}
