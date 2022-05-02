using System;
using System.Collections.Generic;

namespace DataAccess.Entity
{
    public class Category
    {
        public Category()
        {

        }
        public Category(string categoryname)
        {
            CategoryName = categoryname;
        }
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public static List<Category> categoryList = new List<Category>();

        //Mapping
        public List<MoviesCategory> MoviesCategories { get; set; }
        


    }
}
