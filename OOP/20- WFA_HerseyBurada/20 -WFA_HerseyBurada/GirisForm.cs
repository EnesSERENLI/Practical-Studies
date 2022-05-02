using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20__WFA_HerseyBurada
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        #region FormGeçişleri
        //void Settings(Form childform)
        //{
        //    this.Width = childform.Width + 25;
        //    this.Height = childform.Height + 50;
        //    bool durum = false;
        //    foreach (Form child in this.MdiChildren)
        //    {                
        //        if (child.Text == childform.Text)
        //        {
        //            durum = true;
        //            child.Activate();
        //        }
        //        else
        //        {
        //            child.Close();
        //        }                
        //    }
        //    if (durum == false)
        //    {
        //        childform.MdiParent = this;
        //        childform.StartPosition = FormStartPosition.Manual;
        //        childform.FormBorderStyle = FormBorderStyle.None;
        //        childform.Show();
        //    }
        //} 
        #endregion
        
        void Settings(Form childform)
        {
            this.Width = childform.Width+5;
            this.Height = childform.Height+30;
            bool durum = false;
            foreach (Form _child in this.MdiChildren)
            {
                if (_child.Text == childform.Text)
                {
                    _child.Activate();
                    durum = true;
                }
                else
                {
                    _child.Close();
                }
            }
            if (durum==false)
            {
                childform.MdiParent = this;
                childform.StartPosition = FormStartPosition.Manual;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Show();
            }
        }
        public static void Sifirla(GroupBox grp)
        {
            foreach (Control ctrl in grp.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 1;
                }
            }
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new CepTelefonu());
        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new Bilgisayar());
        }

        private void sepetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new Sepetim());    
        }

        private void erkekGiyimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new ErkekGiyim());
        }

        private void kadınGiyimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new KadinGiyim());
        }

        private void telefonEkleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Settings(new TelefonEkle());
        }

        private void telefonSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new TelefonSil());
        }

        private void telefonGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new TelefonGuncelle());
        }

        private void bilgisayarEkleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Settings(new BilgisayarEkle());
        }

        private void bilgisayarSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new Bilgisayar_Sil());
        }

        private void bilgisayarGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new BilgisayarGuncelle());
        }

        private void erkekGiyimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings(new ErkekGiyimEkle()); 
        }

        private void erkekGiyimToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Settings(new ErkekGiyimSil());
        }

        private void erkekGiyimToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Settings(new ErkekGiyimGuncelle());
        }

        private void kadınGiyimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings(new KadinGiyimEkle());
        }

        private void kadınGiyimToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Settings(new KadınGiyimSil());
        }

        private void kadınGiyimToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Settings(new KadınGiyimGuncelle());
        }
    }
}
