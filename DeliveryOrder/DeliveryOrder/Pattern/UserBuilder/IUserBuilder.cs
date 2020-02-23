using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryOrder.Model.SqlModel;

namespace DeliveryOrder.Pattern.UserBuilder
{
    public interface IUserBuilder
    {
        void Add(ISqlModel model);
        UserInfo GetUserInfo();
        void SubmitUser();
    }
}
