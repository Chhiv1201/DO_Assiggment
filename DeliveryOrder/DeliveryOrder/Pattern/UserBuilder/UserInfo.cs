using DeliveryOrder.Model.SqlModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Pattern.UserBuilder
{
    public class UserInfo
    {
        public User user = new User();
        public Staff staff = new Staff();
        public CarDriver carDriver = new CarDriver();
        public MotoDriver motoDriver = new MotoDriver();
        public Coperator coperator = new Coperator();
    }
}
