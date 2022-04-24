using BLL.Service;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.Model
{
    public class Admin: AppUser, IAdmin,IProductService,ICategoryService
    {
        ProjectContext db = new ProjectContext();

        //List
        public override void CategoryList()
        {
            var results = db.Categories.Select(x => new
            {
                x.ID,
                x.CategoryName
            });
            foreach (var category in results)
            {
                Console.WriteLine("CategoryID: " + category.ID + " CategoryName: " + category.CategoryName);
            }
        }

        public override void ProductList()
        {
            foreach (Product p in db.Products)
            {
                Console.WriteLine("ProductID: " + p.ID + " ProductName: " + p.ProductName + " UnitPrice: " + p.UnitPrice + " UnitInStock: " + p.UnitInStock);
            }
        }
        //Report
        public void ReportProductWithPrice(int price1, int price2)
        {
            var results = db.Products.Where(x => x.UnitPrice > price1 && x.UnitPrice < price2).Select(x => new
            {
                x.ProductName,
                x.UnitPrice
            });
            foreach (var product in results)
            {
                Console.WriteLine("ProductName: "+product.ProductName+" UnitPrice: "+product.UnitPrice);
            }
        }

        public void ReportProductWithStock(int stock)
        {
            var results = db.Products.Where(x => x.UnitInStock > stock).Select(x => new
            {
                x.ProductName,
                x.UnitInStock
            });
            foreach (var product in results)
            {
                Console.WriteLine("ProductName: " + product.ProductName + " UnitInStock: " + product.UnitInStock);
            }
        }

        public void ReportProductWithCategory()
        {
            var results = db.Products.GroupBy(x => x.Category.CategoryName).Select(x => new
            {
                CategoryName=x.Key , ProductQuantity = x.Count()
            });
            foreach (var product in results)
            {
                Console.WriteLine("CategoryName: " + product.CategoryName +" "+ "Quantity: " + product.ProductQuantity);
            }
        }
        //CRUD
        public string CreateProduct(Product product)
        {            
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return "Product Added.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateProduct(Product product)
        {           
            try
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Product Updated.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteProduct(int id)
        {            
            try
            {
                Product deleted = db.Products.Find(id);
                db.Products.Remove(deleted);
                db.SaveChanges();
                return "Product Deleted.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CreateCategory(Category category)
        {           
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return "Category Added.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateCategory(Category category)
        {            
            try
            {
                db.Entry(category).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Category Updated.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteCategory(int id)
        {
            try
            {
                Category deleted = db.Categories.Find(id);
                db.Categories.Remove(deleted);
                db.SaveChanges();
                return "Category Deleted.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }           
        }
    }
}
