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
    public partial class TelefonEkle : Form
    {
        public TelefonEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Telefon tel = new Telefon();
            tel.UrunEkle(txtMarka.Text,txtModel.Text,nudFiyat.Value);
        }
    }
}
