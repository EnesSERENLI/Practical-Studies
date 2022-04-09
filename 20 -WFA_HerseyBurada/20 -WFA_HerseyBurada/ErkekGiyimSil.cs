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
    public partial class ErkekGiyimSil : Form
    {
        public ErkekGiyimSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Giyim erkekGiyim = new Giyim();
            erkekGiyim.UrunSil(txtKategori.Text,txtMarka.Text);
        }
    }
}
