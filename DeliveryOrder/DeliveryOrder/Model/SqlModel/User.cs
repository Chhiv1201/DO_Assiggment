using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlModel
{
    public class User : ISqlModel
    {
        public string ID { get; set; }        
        public string UserName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string RoleID { get; set; }

        public Dictionary<string, dynamic> AsDictionary()
        {
            Dictionary<string, dynamic> dic = new Dictionary<string, dynamic>();

            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                dic.Add(property.Name, property.GetValue(this, null));
            }
            return dic;
        }

        public Dictionary<string, dynamic> FieldNotNullAsDictionary()
        {
            Dictionary<string, dynamic> dic = new Dictionary<string, dynamic>();

            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var value=property.GetValue(this, null);
                if (value!=null)
                dic.Add(property.Name, value);
            }
            return dic;

        }
    }
}
