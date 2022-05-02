using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_Kimbilir
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        void ChangeForm(Form childForm)
        {
            bool durum = false;
            this.Width = childForm.Width+15;
            this.Height = childForm.Height+55;
            foreach (Form _child in this.MdiChildren)
            {
                if(_child.Name == childForm.Name)
                {
                    durum = true;
                    _child.Activate();
                }
                else
                {
                    _child.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;                
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.StartPosition = FormStartPosition.Manual;
                childForm.Show();
            }
        }
        private void kimbiliAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new KimBilir());
        }

        private void sınıfLİstesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm(new Kisiler());
        }
    }
}
