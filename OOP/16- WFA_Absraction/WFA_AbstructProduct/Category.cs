using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AbstructProduct
{
    public class Category:BaseClass
    {
        public Category()
        {

        }
        public Category(string cName,string desciription)
        {
            CategoryName = cName;
            Description = desciription;
        }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public override bool IsActive { get; set; }

        public override Product Add(Product p)
        {
            return p;
        }

        public override Category Add(Category c)
        {
            FakeDatabase.Database.categoryList.Add(c);
            
            return c;
        }

        public override Supplier Add(Supplier s)
        {
            return s;
        }

        public override void Delete(string categoryName)
        {
            foreach (Category c in FakeDatabase.Database.categoryList)
            {
                if (c.CategoryName == categoryName)
                {
                    FakeDatabase.Database.categoryList.Remove(c);
                }
            }
        }
        public override string ToString()
        {
            return CategoryName;
        }
        public override void Update(string categoryName, string updateCategoryName)
        {
            foreach (Category c in FakeDatabase.Database.categoryList)
            {
                if (c.CategoryName == categoryName)
                {
                    c.CategoryName = updateCategoryName;
                }
            }
        }

        //public override string Add()
        //{

        //}

        //public override string Delete()
        //{

        //}

        //public override string List()
        //{

        //}

        //public override string Update()
        //{

        //}

    }
}
