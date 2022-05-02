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
    public partial class Sepetim : Form
    {
        public Sepetim()
        {
            InitializeComponent();

        }
        decimal toplamTutar;
        private void Sepetim_Load(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            toplamTutar = sepet.SepetSettings(listView1);
            lblToplam.Text = toplamTutar.ToString("C2");
        }

        private void btnAlisveris_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sipariş vermek istediğinize emin misiniz ?"+"\n"+"Sepet Tutarınız => "+toplamTutar.ToString("C2"),"Sipariş Tamamla",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                listView1.Items.Clear();
                toplamTutar = 0;
                lblToplam.Text = toplamTutar.ToString();
                MessageBox.Show("Siparişiniz alınmıştır! İyi günlerde kullanın.","Sipariş Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
