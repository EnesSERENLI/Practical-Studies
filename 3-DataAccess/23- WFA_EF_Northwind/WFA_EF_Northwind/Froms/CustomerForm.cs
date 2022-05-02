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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        void GetCustomerList()
        {
            listView1.Items.Clear();
            foreach (Customer c in db.Customers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.CustomerID;
                lvi.SubItems.Add(c.CompanyName);
                lvi.SubItems.Add(c.ContactName);
                lvi.SubItems.Add(c.ContactTitle);
                lvi.Tag = c;
                listView1.Items.Add(lvi);
            }
        }
        void AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();            
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomerList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerID = txtCustomerID.Text;
            customer.CompanyName = txtCompanyName.Text;
            customer.ContactName = txtContactName.Text;
            customer.ContactTitle = txtContactTitle.Text;
            AddCustomer(customer);
            GetCustomerList();
        }
    }
}
