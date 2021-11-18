using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWebApplication.Models
{
    public class ProductModel
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