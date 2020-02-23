using DeliveryOrder.Model.SqlModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Pattern.UserBuilder
{
    public class UserBuilder
    {
        private readonly IUserBuilder userBuilder;
        public UserBuilder(IUserBuilder builder)
        {
            userBuilder = builder;
        }

        public UserBuilder(string userType)
        {

            switch(userType.ToLower())
            {
                case "cardriver":
                    userBuilder = new CarDriverBuilder();

                    break;
                case "motodriver":
                    userBuilder = new MotoDriverBuilder();

                    break;
                case "admin":
                    userBuilder = new AdminBuilder();
                    break;
                case "saler":
                    userBuilder = new CoperatorBuilder();
                    break;
            }
        }

        public UserInfo GetUserInfo()
        {
            return userBuilder.GetUserInfo();
        }

        public UserBuilder AddInfo(ISqlModel info)
        {
            userBuilder.Add(info);

            return this;
        }

        public void SubmitDB()
        {
            userBuilder.SubmitUser();
        }
    }
}
