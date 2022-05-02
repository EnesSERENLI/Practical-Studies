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
    public partial class ExtraOlustur : Form
    {
        public ExtraOlustur()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Extra ex = new Extra();
            ex.ExtraName = txtEkstra.Text;
            ex.Price = nudEkstraFiyat.Value;
            ex.Add(ex);
        }
    }
}
