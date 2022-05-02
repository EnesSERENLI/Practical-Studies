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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        //FakeDatabase.Database database = new FakeDatabase.Database();
        Product p;
        private void btnGoSupplier_Click(object sender, EventArgs e)//Form geçişi
        {
            SupplierForm sForm = new SupplierForm();
            sForm.Show();
            this.Hide();
        }
        private void btnGoCategory_Click(object sender, EventArgs e) //Form geçişi
        {
            CategoryForm cForm = new CategoryForm();
            cForm.Show();
            this.Hide();
        }
        private void btnAddProduct_Click(object sender, EventArgs e) //Ürün ekleme -- Listeye ve listbox'a
        {
            p = new Product(txtProductName.Text, nudUnitPrice.Value, Convert.ToInt16(txtUnitInStock.Text), (Category)cmbCategory.SelectedItem, (Supplier)cmbSupplier.SelectedItem);
            lstProduct.Items.Add(p.Add(p));
        }
        private void cmbCategory_MouseClick(object sender, MouseEventArgs e) //cmbcategory'e kategorilerin eklenmesi
        {
            foreach (Category category in Database.categoryList)
            {
                if (!cmbCategory.Items.Contains(category))
                {
                    cmbCategory.Items.Add(category);
                }
            }
        }
        private void cmbSupplier_MouseClick(object sender, MouseEventArgs e)//cmbSupplier'a supplier'lerin eklenmesi
        {
            foreach (Supplier supp in FakeDatabase.Database.supplierList)
            {
                if (!cmbSupplier.Items.Contains(supp))
                {
                    cmbSupplier.Items.Add(supp);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) // Delete
        {
            p.Delete(txtProductName.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e) //update
        {
            Product p = new Product();
            p.Update(txtProductName.Text,txtUpdate.Text);
            //foreach (Product pr in Database.productList) --deneme amaçlı
            //{
            //    MessageBox.Show(pr.ProductName);
            //}
        }
    }
}
