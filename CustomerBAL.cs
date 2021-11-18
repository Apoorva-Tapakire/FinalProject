using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalLibrary
{

    public class CustomerBAL:CustomerLoginBAL
    {
        public int CustomerId { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long MobileNo { get; set; }
        public string City { get; set; }

        

    }
}

