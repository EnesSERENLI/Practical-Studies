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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void GetProducts()
        {
            listView1.Items.Clear();
            foreach (Product product in db.Products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                //if (product.CategoryID == null)
                //{
                //    lvi.SubItems.Add("Tanımsız");
                //}
                //else
                //{
                //    lvi.SubItems.Add(product.Category.CategoryName);
                //}
                string categoryName = product.CategoryID == null ? "Tanımsız" : product.Category.CategoryName; //ternary if
                lvi.SubItems.Add(categoryName);
                listView1.Items.Add(lvi);
            }
        }
        private void GetProducts(bool val)
        {
            listView1.Items.Clear();
            List<Product> products;
            if (val)
            {
                products = db.Products.OrderBy(x => x.UnitPrice).ToList();
            }
            else
            {
                products = db.Products.OrderByDescending(x => x.UnitPrice).ToList();
            }



            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                string categoryName = product.CategoryID == null ? "Tanımsız" : product.Category.CategoryName;
                lvi.SubItems.Add(categoryName);
                listView1.Items.Add(lvi);
            }
        }
        private void GetProducts(string param)
        {
            listView1.Items.Clear();

            List<Product> products = db.Products.Where(x => x.ProductName.Contains(param)).ToList();

            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                //if (product.CategoryID == null)
                //{
                //    lvi.SubItems.Add("Tanımsız");
                //}
                //else
                //{
                //    lvi.SubItems.Add(product.Category.CategoryName);
                //}
                string categoryName = product.CategoryID == null ? "Tanımsız" : product.Category.CategoryName; //ternary if
                lvi.SubItems.Add(categoryName);
                listView1.Items.Add(lvi);
            }
        }
        private void GetProducts(int id)
        {
            listView1.Items.Clear();
            List<Product> products = db.Products.Where(x => x.CategoryID == id).ToList();

            foreach (Product p in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ProductID.ToString();
                lvi.SubItems.Add(p.ProductName);
                lvi.SubItems.Add(p.UnitPrice.ToString());
                lvi.SubItems.Add(p.UnitsInStock.ToString());
                //if (product.CategoryID == null)
                //{
                //    lvi.SubItems.Add("Tanımsız");
                //}
                //else
                //{
                //    lvi.SubItems.Add(product.Category.CategoryName);
                //}
                string categoryName = p.CategoryID == null ? "Tanımsız" : p.Category.CategoryName; //ternary if
                lvi.SubItems.Add(categoryName);
                listView1.Items.Add(lvi);
            }
        }
        private void AddProduct(Product p)
        {
            try
            {
                db.Products.Add(p);
                db.SaveChanges();
                MessageBox.Show(p.ProductName + " kaydedildi.");
                GetProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetProducts();
            //foreach (Category c in db.Categories)
            //{
            //    if (!cmbCategory.Items.Contains(c.CategoryName))
            //    {
            //        cmbCategory.Items.Add(c.CategoryName);
            //        cmbCategory.Tag = c;
            //    }        
            //}
            cmbCategory.DataSource = db.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";//cmbde gösterilecek olan item
            cmbCategory.ValueMember = "CategoryID"; //cmbde seçince alınacak değer.
            
            cmbSelectCategory.DisplayMember = "CategoryName";
            cmbSelectCategory.ValueMember = "CategoryID";
            cmbSelectCategory.DataSource = db.Categories.ToList();

            lblTotalCategory.Text = db.Categories.Count().ToString();
            lblTotalProduct.Text = db.Products.Count().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = txtProductName.Text;
            p.UnitPrice = nudUnitPrice.Value;
            p.UnitsInStock = Convert.ToInt16(nudUnitInStock.Value);
            p.CategoryID = (int)cmbCategory.SelectedValue;
            AddProduct(p);
        }

        private void rbUnitPriceAsc_CheckedChanged(object sender, EventArgs e)
        {
            GetProducts(true);
        }

        private void rbUnitPriceDesc_CheckedChanged(object sender, EventArgs e)
        {
            GetProducts(false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetProducts(txtSearch.Text);
        }

        private void cmbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryıd = Convert.ToInt32(cmbSelectCategory.SelectedValue);
            GetProducts(categoryıd);
        }
    }
}
