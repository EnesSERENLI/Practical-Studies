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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width + 5;
            this.Height = _childForm.Height + 28;
            bool durum = false;
            foreach (Form frm in MdiChildren)
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
        private void hamburgerPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new HamburgerForm());
        }

        private void adminPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AdminForm());
        }

        private void reportPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ReportForm());
        }
    }
}
