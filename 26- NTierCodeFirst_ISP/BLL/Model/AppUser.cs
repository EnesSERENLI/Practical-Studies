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
    public class AppUser : BaseUser,IAppUser
    {
        ProjectContext db = new ProjectContext();
        /// <summary>
        /// Lists all categories
        /// </summary>
        public virtual void CategoryList()
        {
            foreach (Category category in db.Categories)
            {
                Console.WriteLine("CategoryID: " + category.ID+ " CategoryName: " + category.CategoryName);
            }
        }
        /// <summary>
        /// Lists all products
        /// </summary>
        public virtual void ProductList()
        {
            foreach (Product p in db.Products)
            {
                Console.WriteLine("ProductID: " + p.ID +" ProductName: " + p.ProductName+" UnitPrice: "+p.UnitPrice+" UnitInStock: "+p.UnitInStock);
            }
        }
    }
}
