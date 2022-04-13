using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_NorthwindCodeFirst.ORM.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Mapping
        public List<Product> Products { get; set; }

    }
}
