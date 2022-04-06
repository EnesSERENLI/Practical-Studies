using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_McAdamOOP2.Database;

namespace WFA_McAdamOOP2
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
            decimal ciro = Database.Database.CiroHesapla();
            decimal extra = Database.Database.ExtraHesapla();
            decimal toplamSipariAdedi = Database.Database.ToplamSiparisAdetHesapla();
            decimal satilanUrunAdet = Database.Database.SatilanUrunAdetHesapla();
            lblCiro.Text = ciro.ToString("C2");
            lblExGelir.Text = extra.ToString("C2");
            lblToplamSiparis.Text = toplamSipariAdedi.ToString();
            lblSatilanUrunAdet.Text = satilanUrunAdet.ToString();
            Yaz();
        }
        private void Yaz()
        {
            foreach (string siparis in Database.Database.siparislerListesi)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if(ctrl is ListBox)
                    {
                        ListBox lst = (ListBox)ctrl;
                        lst.Items.Add(siparis);
                        break;
                    }
                }
            }
        }
    }
}
