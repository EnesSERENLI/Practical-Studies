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
    public partial class Bilgisayar : Form
    {
        public Bilgisayar()
        {
            InitializeComponent();
        }

        private void Bilgisayar_Load(object sender, EventArgs e)
        {
            foreach (Computer bilgisayar in Computer.computerList)
            {
                if (!cmbMarka.Items.Contains(bilgisayar.Marka))
                {
                    cmbMarka.Items.Add(bilgisayar.Marka);
                }
            }
            foreach (RAM ram in RAM.ramListesi)
            {
                cmbRam.Items.Add(ram);
            }
            foreach (EkranKarti ekart in EkranKarti.ekranKartiListesi)
            {
                cmbEkranKarti.Items.Add(ekart);
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.SelectedIndex = -1;
            cmbModel.Items.Clear();
            foreach (Computer bilgisayar in Computer.computerList)
            {
                if (cmbMarka.SelectedItem == bilgisayar.Marka)
                {
                    cmbModel.Items.Add(bilgisayar);
                }
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex != -1 && cmbModel.SelectedIndex != -1 && cmbRam.SelectedIndex != -1 && cmbEkranKarti.SelectedIndex != -1)
            {
                Computer bilgisayar = (Computer)cmbModel.SelectedItem;
                bilgisayar.RAM = (RAM)cmbRam.SelectedItem;
                bilgisayar.EkranKarti = (EkranKarti)cmbEkranKarti.SelectedItem;
                bilgisayar.Adet = nudAdet.Value;
                lblFiyat.Text = bilgisayar.TutarHesapla(bilgisayar).ToString("C2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex != -1 && cmbModel.SelectedIndex != -1 && cmbRam.SelectedIndex != -1 && cmbEkranKarti.SelectedIndex != -1)
            {
                Computer bilgisayar = cmbModel.SelectedItem as Computer;
                bilgisayar.RAM = (RAM)cmbRam.SelectedItem;
                bilgisayar.EkranKarti = (EkranKarti)cmbEkranKarti.SelectedItem;                
                bilgisayar.Adet = nudAdet.Value;
                listView1.Items.Add(bilgisayar.SepeteEkle(bilgisayar));
                Sepet.sepetim.Add(bilgisayar);
                GirisForm.Sifirla(groupBox1);
            }
        }
    }
}
