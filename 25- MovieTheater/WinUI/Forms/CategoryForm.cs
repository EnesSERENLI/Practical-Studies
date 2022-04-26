using BussinessLogicLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        CategoryService categoryService = new CategoryService();
        private void btnListCategory_Click(object sender, EventArgs e)
        {
            categoryService.CategoryList(listView1);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
               string result = categoryService.AddCategory(txtAddCategory.Text);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string result = categoryService.UpdateCategory(int.Parse(txtUpdateCategoryID.Text),txtUpdateCategoryName.Text);
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show("CategoryID cannot be blank and must be an integer.");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string result = categoryService.DeleteCategory(int.Parse(txtDeleteCategoryID.Text));
                MessageBox.Show(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show("CategoryID canot be blank and must be an integer.!");
            }
        }
    }
}
