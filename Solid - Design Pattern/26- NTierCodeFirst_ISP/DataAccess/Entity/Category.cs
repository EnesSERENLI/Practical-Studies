using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Category
    {
        public Category()
        {

        }
        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
        public int ID { get; set; }
        public string CategoryName { get; set; }
        //Mapping
        public List<Product> Products { get; set; }
    }
}
