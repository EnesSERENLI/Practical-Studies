using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Tools;
using Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    
    public class CategoryService:BaseService<Category>
    {
        EcommerceContext context = DbContextSingleton.Context;
        //public CategoryService()
        //{
        //    Category category = new Category();
        //    category.CategoryName = "Aksesuar";
        //    category.Description = "asdasdasdsad";

        //    Add(category);
        //}
        public void ProductCount(string categoryName)
        {
            var result = GetContext().Products.SqlQuery(@"select count(*) from Categories c join SubCategories sc on sc.CategoryId=c.ID join Products p on p.SubCategoryId=sc.ID Where c.CategoryName = '" + categoryName + "'");
        }
    }   
}
