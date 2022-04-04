using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AbstructProduct
{
    public class Product : BaseClass
    {
        public Product()
        {

        }
        public Product(string pName, decimal uPrice, short uStock, Category category, Supplier supplier)
        {
            ProductName = pName;
            UnitPrice = uPrice;
            UnitInStock = uStock;
            Category = category;
            Supplier = supplier;
            CreateDate = DateTime.Now;
            IsActive = true;
        }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        private bool _isActive;
        public override bool IsActive //Encapsulation eğer stok 0'a inerse ürün passive olacak.
        {
            get
            {
                return _isActive;
            }
            set
            {
                if (UnitInStock == 0)
                {
                    value = false;
                    _isActive = value;
                }
            }
        }
        public override string ToString()
        {
            return "ProductName: " + ProductName + " " + "UnitPrice: " + UnitPrice.ToString("C2") + " " + "StockQuantity:" + UnitInStock+" Category: "+Category + " Supplier: "+Supplier;
        }

        public override Product Add(Product product) //ürün ekleme
        {
            FakeDatabase.Database.productList.Add(product);
            return product;
        }

        public override Category Add(Category c)
        {
            return c;
        }

        public override Supplier Add(Supplier s)
        {
            return s;
        }

        public override void Delete(string productName) // ürün silme ????? System.InvalidOperationException????
        {
            foreach (Product p in FakeDatabase.Database.productList)
            {
                if (p.ProductName == productName)
                {
                    FakeDatabase.Database.productList.Remove(p);
                }
            }
        }
        public override void Update(string productName, string updateName) //Güncelleme
        {
            foreach (Product p in FakeDatabase.Database.productList)
            {
                if (p.ProductName == productName)
                {
                    p.ProductName = updateName;
                }
            }
        }
        //public override string List(List<Product> p)
        //{
            
        //    foreach (Product pr in p)
        //    {
        //       return pr.ProductName;
        //    }
            
        //}

        //public override string List(List<Category> c)
        //{
        //    return "";
        //}

        //public override string List(List<Supplier> s)
        //{
        //    return "";
        //}
    }
}
