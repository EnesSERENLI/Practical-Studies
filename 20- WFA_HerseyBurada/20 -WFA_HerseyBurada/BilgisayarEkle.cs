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
    public partial class BilgisayarEkle : Form
    {
        public BilgisayarEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Computer pc = new Computer();
            pc.UrunEkle(txtMarka.Text,txtModel.Text,nudFiyat.Value);
        }
    }
}
