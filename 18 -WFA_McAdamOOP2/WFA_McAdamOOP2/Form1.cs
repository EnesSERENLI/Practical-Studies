using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdamOOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void childForm(Form _childForm)
        {
            this.Width =_childForm.Width+22;
            this.Height =_childForm.Height+68;
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
        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SiparisOlustur());
        }

        private void menuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MenuOlustur());
        }

        private void extraOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new ExtraOlustur());
        }

        private void menuGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MenuGuncelle());
        }

        private void extraGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new ExtraGuncelle());
        }

        private void extraSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new ExtraSil());
        }

        private void menuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MenuSil());
        }

        private void siparislerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new Siparisler());
        }
    }
}
