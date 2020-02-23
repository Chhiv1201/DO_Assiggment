using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrder
{
    public class operation
    {
        public string NewID()
        {
            return Guid.NewGuid().ToString().ToUpper();
        }
    }
}
