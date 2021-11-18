using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWebApplication.Models
{
    public class PaymentModel
    {
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public string UPINo { get; set; }
        public long CardNo { get; set; }
        public long CVVNo { get; set; }
    }
}