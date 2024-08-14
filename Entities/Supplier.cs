using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StockManagement.Entities
{
    [Serializable]
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public Supplier(int supplierId, string name, string contactInfo)
        {
            SupplierId = supplierId;
            Name = name;
            ContactInfo = contactInfo;
        }
    }
}
