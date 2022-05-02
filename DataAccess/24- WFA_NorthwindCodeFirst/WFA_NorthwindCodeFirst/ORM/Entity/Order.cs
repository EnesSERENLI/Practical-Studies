using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_NorthwindCodeFirst.ORM.Entity
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public decimal Freight { get; set; }

        //Mapping

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
