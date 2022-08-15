using BLL.EntityTypeRepository;
using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByteSorular
{
    internal class Program
    {
        static int Diffrent(int[] deger)
        {
            int result = 0;
            foreach (int num in deger)
            {
                if (!deger.Contains(num + 2))
                {
                    result = num + 2;
                    break;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {

            //int[] nums = new int[] { 1, 3, 5, 9, 11 };


            //Console.WriteLine(Diffrent(nums));
            //Console.Read();
            ProductService productService = new ProductService();
            CategoryService categoryService = new CategoryService();

            Category category = new Category();
            category.CategoryName = "Meyve";
            category.Description = "Orman Meyvesi";
            category.Status = DAL.Enums.Status.Active;
            categoryService.Add(category);

            Product product = new Product();
            product.ProductName = "Elma";
            product.UnitPrice = 10;
            product.UnitsInStock = 100;
            product.Description = "Yeşil Elma";
            product.CategoryId = category.ID;

            productService.Add(product);

            var categories = categoryService.GetList();
            var products = productService.GetList();

            foreach (Category c in categories)
            {
                Console.WriteLine(c.CategoryName);
            }

            foreach (Product p in products)
            {
                Console.WriteLine(p.ProductName + " " + p.Description + " UnitPrice: " + p.UnitPrice + " UnitsInStock: " + p.UnitsInStock);
            }

            Console.Read();
            
            
        }
    }
}
