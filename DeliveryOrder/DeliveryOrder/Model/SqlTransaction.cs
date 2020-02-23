using DeliveryOrder.Model.SingleTon;
using DeliveryOrder.Model.SqlCmdBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model
{
    class SqlTransaction
    {
        Database db_ = Database.Instance;
        void SampleSelect()
        {

            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Select = new SqlQueryBuilder(new SqlSelect());
                //Using Builder
                string query = Select.Fields("")
                                     .Table("")
                                     .Where("")
                                     .GetQueryString();
                //Using Single Tone
                db_.Read(query);

            }
            catch (Exception)
            {

            }
            finally
            {
                db_.Disconnect();
            }
        }
        void SampleInsert()
        {
            Dictionary<string, dynamic> fields = new Dictionary<string, dynamic>();
            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Insert = new SqlQueryBuilder(new SqlInsert());
                //Using Builder
                string query = Insert.Fields(fields.Keys.ToArray())
                                     .Table("")
                                     .Where("")
                                     .GetQueryString();
                //Using Single Tone
                db_.Transaction(query, fields);

            }
            catch (Exception)
            {

            }
            finally
            {
                db_.Disconnect();
            }
        }
        void SampleDelete()
        {
            Dictionary<string, dynamic> fields = new Dictionary<string, dynamic>();
            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Delete = new SqlQueryBuilder(new SqlDelete());
                //Using Builder
                string query = Delete.Fields(fields.Keys.ToArray())
                                     .Table("")
                                     .Where("")
                                     .GetQueryString();
                //Using Single Tone
                db_.Transaction(query, fields);

            }
            catch (Exception)
            {

            }
            finally
            {
                db_.Disconnect();
            }
        }
        void SampleUpdate()
        {
            Dictionary<string, dynamic> fields = new Dictionary<string, dynamic>();
            try
            {
                db_.DefaultConnect();
                SqlQueryBuilder Update = new SqlQueryBuilder(new SqlUpdate());
                //Using Builder
                string query = Update.Fields(fields.Keys.ToArray())
                                     .Table("")
                                     .Where("")
                                     .GetQueryString();
                //Using Single Tone
                db_.Transaction(query, fields);

            }
            catch (Exception)
            {

            }
            finally
            {
                db_.Disconnect();
            }
        }
    }
}
