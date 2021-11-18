using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalLibrary
{
    public class ProductBAL
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ActualPrice { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Byte[] Image { get; set; }
        public int CategoryId { get; set; }
    }
}
