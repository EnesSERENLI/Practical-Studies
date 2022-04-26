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
    public partial class Bilgisayar_Sil : Form
    {
        public Bilgisayar_Sil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Computer pc  = new Computer();
            pc.UrunSil(txtMarka.Text,txtModel.Text);
        }
    }
}
