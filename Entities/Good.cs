using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    [Serializable]
    public class Good 
    {
        public int GoodId { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public static List<Supplier> Suppliers { get; set; }


        public Good  (int goodId, string name, int supplierId) {
            GoodId = goodId;
            Name = name;   
            SupplierId = supplierId;
        }
       


    }

}
