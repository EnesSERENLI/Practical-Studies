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
    public partial class ShipperForm : Form
    {
        public ShipperForm()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        void GetShipperList()
        {
            listView1.Items.Clear();
            foreach (Shipper s in db.Shippers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.ShipperID.ToString();
                lvi.SubItems.Add(s.CompanyName);
                lvi.SubItems.Add(s.Phone);
                lvi.Tag = s;
                listView1.Items.Add(lvi);
            }
        }
        void AddShipper(Shipper s)
        {
            db.Shippers.Add(s);
            db.SaveChanges();
            GetShipperList();
        }
        private void ShipperForm_Load(object sender, EventArgs e)
        {
            GetShipperList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shipper s = new Shipper();
            s.CompanyName = txtCompanyName.Text;
            s.Phone = txtPhone.Text;
            AddShipper(s);
        }
    }
}
