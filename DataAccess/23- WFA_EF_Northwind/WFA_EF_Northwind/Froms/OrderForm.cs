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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        void GetOrderList()
        {
            listView1.Items.Clear();
            foreach (Order o in db.Orders)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = o.OrderID.ToString();
                lvi.SubItems.Add(o.OrderDate.Value.ToString());
                lvi.SubItems.Add(o.Freight.ToString());
                lvi.Tag = o;
                listView1.Items.Add(lvi);
            }
        }
        void AddOrder(Order o)
        {
            db.Orders.Add(o);
            db.SaveChanges();
            GetOrderList();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetOrderList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.OrderDate = dateTimePicker1.Value;
            order.Freight = numericUpDown1.Value;
            AddOrder(order);
        }
    }
}
