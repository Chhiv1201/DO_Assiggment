using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlModel
{
    public class Product : ISqlModel
    {
        public string                           ID { get; set; }
        public string                           Name { get; set; }
        public string                           Description { get; set; }
        public string                           ProductType { get; set; }
        public string                           SalerID { get; set; }
        public string                           SalerName { get; set; }
        public System.Nullable<System.DateTime> CheckInDate { get; set; }
        public string                           ToLocation { get; set; }
        public string                           CusPhone { get; set; }
        public string                           CusAddress { get; set; }
        public string                           TakerID { get; set; }
        public string                           TakeBy { get; set; }
        public System.Nullable<System.DateTime> TakeDate { get; set; }
        public System.Nullable<System.DateTime> CloseDate { get; set; }
        public string                           Status { get; set; }
        public string                           Note{ get; set; }

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
