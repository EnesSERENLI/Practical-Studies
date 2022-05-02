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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        void GetSupplierList()
        {
            listView1.Items.Clear();
            foreach (Supplier s in db.Suppliers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.SupplierID.ToString();
                lvi.SubItems.Add(s.CompanyName);
                lvi.SubItems.Add(s.ContactName);
                lvi.SubItems.Add(s.Country);
                lvi.Tag = s;
                listView1.Items.Add(lvi);
            }
        }
        void AddSupplier(Supplier s)
        {
            db.Suppliers.Add(s);
            db.SaveChanges();
            GetSupplierList();
        }
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            GetSupplierList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.CompanyName = txtCompanyName.Text;
            s.ContactName = txtContactName.Text;
            s.Country = txtCountry.Text;
            AddSupplier(s);
        }
    }
}
