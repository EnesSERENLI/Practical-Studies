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
    public partial class KadinGiyim : Form
    {
        public KadinGiyim()
        {
            InitializeComponent();
        }

        private void KadinGiyim_Load(object sender, EventArgs e)
        {
            foreach (Giyim kadin in Giyim.kadinGiyimListesi)
            {
                if (!cmbKategori.Items.Contains(kadin.Kategori))
                {
                    cmbKategori.Items.Add(kadin.Kategori);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                Beden beden = (Beden)i;
                switch (beden)
                {
                    case Beden.XS:
                        cmbBeden.Items.Add(beden);
                        break;
                    case Beden.S:
                        cmbBeden.Items.Add(beden);
                        break;
                    case Beden.M:
                        cmbBeden.Items.Add(beden);
                        break;
                    case Beden.L:
                        cmbBeden.Items.Add(beden);
                        break;
                    case Beden.XL:
                        cmbBeden.Items.Add(beden);
                        break;
                    case Beden.XXXL:
                        cmbBeden.Items.Add(beden);
                        break;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                KumasTipi kumas = (KumasTipi)i;
                switch (kumas)
                {
                    case KumasTipi.Dokuma:
                        cmbKumasTipi.Items.Add(kumas);
                        break;
                    case KumasTipi.Örme:
                        cmbKumasTipi.Items.Add(kumas);
                        break;
                    case KumasTipi.Triko:
                        cmbKumasTipi.Items.Add(kumas);
                        break;
                    case KumasTipi.Pamuk:
                        cmbKumasTipi.Items.Add(kumas);
                        break;
                    case KumasTipi.OrganikPamuk:
                        cmbKumasTipi.Items.Add(kumas);
                        break;
                    case KumasTipi.Denim:
                        cmbKumasTipi.Items.Add(kumas);
                        break;
                }
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarka.SelectedIndex = -1;
            cmbMarka.Items.Clear();
            foreach (Giyim kadin in Giyim.kadinGiyimListesi)
            {
                if (cmbKategori.SelectedItem == kadin.Kategori)
                {
                    cmbMarka.Items.Add(kadin);
                }
            }
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex != -1 && cmbMarka.SelectedIndex != -1 && cmbBeden.SelectedIndex != -1 && cmbKumasTipi.SelectedIndex != -1)
            {
                Giyim kadinGiyim = (Giyim)cmbMarka.SelectedItem;
                kadinGiyim.Adet = nudAdet.Value;
                lblFiyat.Text = kadinGiyim.TutarHesapla(kadinGiyim).ToString("C2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex != -1 && cmbMarka.SelectedIndex != -1 && cmbBeden.SelectedIndex != -1 && cmbKumasTipi.SelectedIndex != -1)
            {
                Giyim kadinGiyim = (Giyim)cmbMarka.SelectedItem;
                kadinGiyim.Beden = (Beden)cmbBeden.SelectedItem;
                kadinGiyim.KumasTipi = (KumasTipi)cmbKumasTipi.SelectedItem;
                kadinGiyim.Renk = btnRenk.BackColor;
                kadinGiyim.Adet = nudAdet.Value;
                listView1.Items.Add(kadinGiyim.SepeteEkle(kadinGiyim));
                Sepet.sepetim.Add(kadinGiyim);
            }
        }
    }
}
