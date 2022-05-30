using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Tools;
using Service.Base;
using Service.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EcommerceContext db = new EcommerceContext();
            ProductService productService = new ProductService();
            CategoryService categoryService = new CategoryService();
            AppUserService appUserService = new AppUserService();
            AppUser user = appUserService.GetById(Guid.Parse("005d5503-00f7-486e-97d3-6a22f40e9f63"));
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);
            //productService.ProductCount("giyim");

            //foreach (var category in categoryService.GetList())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            //var updated = categoryService.GetById(Guid.Parse("d668f5f9-4832-476d-abe9-3458c8e37366"));
            //updated.CategoryName = "Oto Aksesuar";
            //categoryService.Update(updated);
            //Console.ReadLine();

            ////Silme
            //categoryService.Delete(Guid.Parse("d668f5f9-4832-476d-abe9-3458c8e37366"));
            //foreach (var item in categoryService.GetDefault(x=>x.Status == Core.Enums.Status.Active))
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            //var result2 = categoryService.GetList();
            //foreach (var category in result2)
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            //var result2 = productService.GetDefault(x => x.UnitInStock > 100); //GetDefault okey
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //Console.ReadLine();

            //var result3 = productService.Any(x => x.ProductName == "MSI"); // Any okey
            //Console.WriteLine(result3);

            //Guid guid = Guid.Parse("be75f2c0-d036-42b0-b494-076ceaf00e91");
            //Product product1 = productService.GetById(guid); //ID ye göre bulma okey..
            //Console.WriteLine(product1.ProductName);

            ////Liste ile ekleme
            //List<Product> products = new List<Product>()
            //{
            //    new Product{ID = Guid.NewGuid(), ProductName="Monster",SubCategoryId=db.SubCategories.FirstOrDefault(x=>x.SubCategoryName =="Bilgisayar").ID,SupplierId=db.Suppliers.FirstOrDefault(x=>x.CompanyName =="Özkardeşler Tic").ID,UnitInStock=80,UnitPrice=18000,ProductImagePath="/Content/product/monster_computer.png"},
            //    new Product{ID = Guid.NewGuid(), ProductName="Skechers",SubCategoryId=db.SubCategories.FirstOrDefault(x=>x.SubCategoryName =="Ayakkabı").ID,SupplierId=db.Suppliers.FirstOrDefault(x=>x.CompanyName =="Kuzey yeli deposu Tic").ID,UnitInStock=500,UnitPrice=120,ProductImagePath="/Content/product/hairsprey.png"}
            //};
            //string result5 = productService.Add(products); //List tipinde ekleme okey
            //Console.WriteLine(result5);
            //Console.ReadLine();

            //var result6 = productService.Any(x => x.ProductName == "Monster"); //ekledimi kontrol işlemi
            //Console.WriteLine(result6);

            //Product updated = productService.GetById(guid);
            //updated.ProductName = "Asus";
            //string result7 = productService.Update(updated); //Güncelleme okey
            //Console.WriteLine(result7);

            //Console.ReadLine();

            //var result8 = productService.Any(x => x.ProductName == "Asus");//Güncelleyince kontrol işlemi
            //Console.WriteLine(result8);

            Console.Read();
        }
    }
}
