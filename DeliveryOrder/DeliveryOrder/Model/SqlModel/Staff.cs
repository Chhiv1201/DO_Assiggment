using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlModel
{
    public class Staff : ISqlModel
    {
        public string UserID { get; set; }
        public string ID { get; set; }
        public string StaffName { get; set; }
        public string Gender { get; set; }
        public System.Nullable<System.DateTime> BirthDate { get; set; }
        public string Position { get; set; }
        public System.Nullable<decimal> Salary { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public System.Nullable<System.DateTime> HiredDate { get; set; }
        public string Contact { get; set; }
        public System.Nullable<bool> StopWork { get; set; }



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
                var value = property.GetValue(this, null);
                if (value != null)
                    dic.Add(property.Name, value);
            }
            return dic;

        }
    }
}
