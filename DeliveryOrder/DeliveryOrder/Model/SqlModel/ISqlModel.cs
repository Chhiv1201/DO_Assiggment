using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder.Model.SqlModel
{
    public interface ISqlModel
    {

        Dictionary<string, dynamic> AsDictionary();
        Dictionary<string, dynamic> FieldNotNullAsDictionary();
    }
}
