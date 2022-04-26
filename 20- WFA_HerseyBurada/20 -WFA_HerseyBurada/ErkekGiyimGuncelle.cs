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
    public partial class ErkekGiyimGuncelle : Form
    {
        public ErkekGiyimGuncelle()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Giyim erkekGiyim = new Giyim();
            erkekGiyim.UrunGuncelle(txtEskiKategori.Text,txtEskiMarka.Text,txtYeniKategori.Text,txtYeniMarka.Text,nudFiyat.Value);
        }
    }
}
