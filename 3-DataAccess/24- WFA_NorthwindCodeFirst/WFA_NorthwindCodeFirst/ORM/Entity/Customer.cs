using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_NorthwindCodeFirst.ORM.Entity
{
    public class Customer
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        //Mapping

        public List<Order> Orders { get; set; }
    }
}
