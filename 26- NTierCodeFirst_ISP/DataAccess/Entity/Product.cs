using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string productName,decimal unitPrice , int unitInStock, int categoryId)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitInStock = unitInStock;
            CategoryId = categoryId;
        }
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        //Mapping
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
