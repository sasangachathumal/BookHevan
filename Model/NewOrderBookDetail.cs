using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookHevan.Model
{
    // This class is used to store the details of a new order book.
    internal class NewOrderBookDetail
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public decimal price { get; set; }
        public string genre { get; set; }
        public string isbn { get; set; }
        public int orderQuantity { get; set; }
    }
}
