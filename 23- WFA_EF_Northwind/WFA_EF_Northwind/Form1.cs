using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_EF_Northwind.Froms;

namespace WFA_EF_Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width + 5;
            this.Height = _childForm.Height + 30;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new CategoryForm());
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ProductForm());
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ReportForm());
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new CustomerForm());
        }

        private void çalışanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new EmployeeForm());  
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new OrderForm());
        }

        private void tedarikçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SupplierForm());
        }

        private void nakliyeciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ShipperForm());
        }
    }
}
