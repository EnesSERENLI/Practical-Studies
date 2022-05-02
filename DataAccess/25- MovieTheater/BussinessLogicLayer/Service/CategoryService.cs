using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessLogicLayer.Service
{
    public class CategoryService
    {
        ProjectContext db = new ProjectContext();

        //Add
        public string AddCategory(string categoryName)
        {
            try
            {
                Category category = new Category();
                category.CategoryName = categoryName;
                db.Categories.Add(category);
                db.SaveChanges();
                return "Category Added.!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //List
        public void CategoryList(ListView lv)
        {
            lv.Items.Clear();
            foreach (Category c in db.Categories)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.ID.ToString();
                lvi.SubItems.Add(c.CategoryName);
                lvi.Tag = c;
                lv.Items.Add(lvi);
            }
        }
        //Update
        public string UpdateCategory(int id,string categoryName)
        {
            Category updated = db.Categories.FirstOrDefault(c => c.ID == id);
            updated.CategoryName = categoryName;
            db.SaveChanges();
            return "Category Updated..!";
        }
        //Delete
        public string DeleteCategory(int id)
        {
            try
            {
                Category deleted = db.Categories.Find(id);
                db.Categories.Remove(deleted);
                db.SaveChanges();
                return "Category Deleted!";
            }
            catch (Exception ex)
            {
                return "You entered an undefined CategoryID number.";
            }
        }
    }
}
