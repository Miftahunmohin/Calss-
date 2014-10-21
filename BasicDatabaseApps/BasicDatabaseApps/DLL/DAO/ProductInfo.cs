using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDatabaseApps.DLL.DAO
{
   public class ProductInfo
    {
       public string ProductCode { set; get; }
       public string ProductName { set; get; }
       public int Quantity { set; get; }
       public int ProductId { get; set; }
    }
}
