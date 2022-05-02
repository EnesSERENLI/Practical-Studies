using DataAccess;
using DataAccess.Entity;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseUser baseUser = new AppUser(); //No error
            BaseUser admin = new Admin(); //No error
            admin.ID = 1;
            admin.UserName = "kramy10";
            admin.Password = "123456";
            admin.Email = admin.UserName.Substring(0, 1) + "@bilgeadam.com";
            Console.WriteLine("AdminID: " + admin.ID + " Username: " + admin.UserName);
            Console.ReadLine();

            //Kategori Ekleme
            //Category c = new Category();
            //c.CategoryName = "Equatorial Fruits";
            Admin newAdmin = new Admin();
            //string result = newAdmin.CreateCategory(c);
            //Console.WriteLine(result);
            //Console.ReadLine();
            newAdmin.CategoryList();
            Console.ReadLine();
            //Ürün ekleme
            //Product product = new Product();
            //product.ProductName = "Dragon Fruit";
            //product.UnitPrice = 50;
            //product.UnitInStock = 3;
            //product.CategoryId = 4;
            //string result2 = newAdmin.CreateProduct(product);
            //Console.WriteLine(result2);
            //Console.ReadLine();
            newAdmin.ProductList();
            Console.ReadLine();
            newAdmin.ReportProductWithCategory(); //Kategoriler ve ürün adetleri
            Console.ReadLine();
            newAdmin.ReportProductWithPrice(5,25);//2 fiyat arası ürün listememe
            Console.ReadLine();
            newAdmin.ReportProductWithStock(2); //Stok miktarına göre ürün listemele           
            Console.Read();
        }
    }
}
