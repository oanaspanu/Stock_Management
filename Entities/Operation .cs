using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    [Serializable]
    public class Operation
    {
        public int OperationId { get; set; }
        public int GoodId { get; set; }
        public int SupplierId { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public static BindingList<Good> Goods { get; set; }
        public static BindingList<Supplier> Suppliers { get; set; }

        public Operation(int operationId, int goodId, int supplierId, string type, int quantity, DateTime date)
        {
            OperationId = operationId;
            GoodId = goodId;
            SupplierId = supplierId;
            Type = type;
            Quantity = quantity;
            Date = date;
        }

    }


}
