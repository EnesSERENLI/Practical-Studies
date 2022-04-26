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
    public partial class TelefonSil : Form
    {
        public TelefonSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Telefon tel = new Telefon();
            tel.UrunSil(txtMarka.Text, txtModel.Text);
        }
    }
}
