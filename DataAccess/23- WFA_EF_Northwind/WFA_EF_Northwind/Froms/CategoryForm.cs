using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_Northwind.Froms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void GetCategories()
        {
            listView1.Items.Clear();
            foreach (Category c in db.Categories)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.CategoryID.ToString();
                lvi.SubItems.Add(c.CategoryName);
                lvi.SubItems.Add(c.Description);
                lvi.Tag = c;
                listView1.Items.Add(lvi);
            }
        }
        private void AddCategory()
        {
            try
            {
                Category c = new Category();
                c.CategoryName = txtCategoryName.Text;
                c.Description = txtDesciription.Text;
                db.Categories.Add(c);
                db.SaveChanges();
                MessageBox.Show(c.CategoryName + " kaydedildi.");
                GetCategories();
                txtCategoryName.Text = "";
                txtDesciription.Text = "";
                txtCategoryName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetCategories();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddCategory();
        }       
    }
}
