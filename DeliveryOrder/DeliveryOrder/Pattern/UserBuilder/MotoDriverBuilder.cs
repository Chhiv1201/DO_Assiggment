using DeliveryOrder.Model.SingleTon;
using DeliveryOrder.Model.SqlCmdBuilder;
using DeliveryOrder.Model.SqlModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryOrder.Pattern.UserBuilder
{
    class MotoDriverBuilder : IUserBuilder
    {
        UserInfo userinfo = new UserInfo();

        public UserInfo GetUserInfo()
        {
            return userinfo;
        }
        public void Add(ISqlModel model)
        {
            string modelName = model.GetType().Name;
            switch (modelName)
            {
                case "User":
                    userinfo.user = (User)model;
                    break;
                case "Staff":
                    userinfo.staff = (Staff)model;
                    break;
                case "MotoDriver":
                    userinfo.motoDriver = (MotoDriver)model;
                    break;
            }
        }

        public void SubmitUser()
        {
            Database db_ = Database.Instance;
            try
            {
                db_.DefaultConnect();
                var dicUser = userinfo.user.FieldNotNullAsDictionary();
                var dicStaff = userinfo.staff.FieldNotNullAsDictionary();
                var dicMotoDriver = userinfo.motoDriver.FieldNotNullAsDictionary();



                SqlQueryBuilder Insert = new SqlQueryBuilder(new SqlInsert());
                //Using Builder
                string Userquery = Insert.Fields(dicUser.Keys.ToArray())
                                     .Table("User")
                                     .GetQueryString();

                string Staffquery = Insert.Fields(dicStaff.Keys.ToArray())
                                     .Table("Staff")
                                     .GetQueryString();

                string MotoDriverquery = Insert.Fields(dicMotoDriver.Keys.ToArray())
                                     .Table("MotoDriver")
                                     .GetQueryString();


                //Using Single Tone
                db_.Transaction(Userquery, dicUser);
                db_.Transaction(Staffquery, dicStaff);
                db_.Transaction(MotoDriverquery, dicMotoDriver);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                db_.Disconnect();
            }

        }
    }
}
