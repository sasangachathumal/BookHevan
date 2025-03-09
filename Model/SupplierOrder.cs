using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.Model
{
    internal class SupplierOrder
    {

        public int id { get; set; }
        public int supplierId { get; set; }
        public int userId { get; set; }
        public string date { get; set; }
        public decimal amount { get; set; }
        public int discount { get; set; }

        public SupplierOrder(int id, int supplierId, int userId, string date, decimal amount, int discount)
        {
            this.id = id;
            this.supplierId = supplierId;
            this.userId = userId;
            this.date = date;
            this.amount = amount;
            this.discount = discount;
        }
        public SupplierOrder() { }
    }
}
