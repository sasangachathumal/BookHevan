using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHevan.Model
{
    internal class SupplierOrderDetails
    {
        public int supplierOrderId { get; set; }
        public int bookId { get; set; }
        public int quantity { get; set; }

        public SupplierOrderDetails(int supplierOrderId, int bookId, int quantity)
        {
            this.supplierOrderId = supplierOrderId;
            this.bookId = bookId;
            this.quantity = quantity;
        }
        public SupplierOrderDetails() { }
    }
}
