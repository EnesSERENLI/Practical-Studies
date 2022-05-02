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
    public partial class KadınGiyimSil : Form
    {
        public KadınGiyimSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Giyim kadinGiyim = new Giyim();
            kadinGiyim.UrunSil(txtKategori.Text,txtMarka.Text);
        }
    }
}
