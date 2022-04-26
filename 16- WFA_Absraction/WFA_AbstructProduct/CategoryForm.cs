using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_AbstructProduct.FakeDatabase;

namespace WFA_AbstructProduct
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        Category c;
        private void btnGoSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm sForm = new SupplierForm();
            sForm.Show();
            this.Hide();
        }

        private void btnGoProducts_Click(object sender, EventArgs e)
        {
            ProductForm pForm = new ProductForm();
            pForm.Show();
            this.Hide();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            c = new Category(txtCategoryName.Text,txtDescription.Text);
            lstCategories.Items.Add(c.Add(c));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Update(txtCategoryName.Text, txtUpdate.Text);
        }
    }
}
