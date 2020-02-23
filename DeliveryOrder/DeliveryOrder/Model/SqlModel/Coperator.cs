using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlModel
{
    public class Coperator : ISqlModel
    {
        public string UserID { get; set; }
        public string StaffName { get; set; }
        public string Gender { get; set; }
        public string CopID { get; set; }
        public System.Nullable<System.DateTime> CopDate { get; set; }
        public string ComLocation { get; set; }
        public string ComName { get; set; }
        public string ComContact { get; set; }




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
