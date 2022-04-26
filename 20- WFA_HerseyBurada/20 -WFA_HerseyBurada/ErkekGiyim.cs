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
    public partial class ErkekGiyim : Form
    {
        public ErkekGiyim()
        {
            InitializeComponent();
        }

        private void ErkekGiyim_Load(object sender, EventArgs e)
        {
            foreach (Giyim erkek in Giyim.erkekGiyimListesi)
            {
                if (!cmbKategori.Items.Contains(erkek.Kategori))
                {
                    cmbKategori.Items.Add(erkek.Kategori);
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
            foreach (Giyim erkek in Giyim.erkekGiyimListesi)
            {
                if (cmbKategori.SelectedItem == erkek.Kategori)
                {
                    cmbMarka.Items.Add(erkek);
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
                Giyim erkekGiyim = (Giyim)cmbMarka.SelectedItem;
                erkekGiyim.Adet = nudAdet.Value;
                lblFiyat.Text = erkekGiyim.TutarHesapla(erkekGiyim).ToString("C2");
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex != -1 && cmbMarka.SelectedIndex != -1 && cmbBeden.SelectedIndex != -1 && cmbKumasTipi.SelectedIndex != -1)
            {
                Giyim erkekGiyim = (Giyim)cmbMarka.SelectedItem;
                erkekGiyim.Beden = (Beden)cmbBeden.SelectedItem;
                erkekGiyim.KumasTipi = (KumasTipi)cmbKumasTipi.SelectedItem;
                erkekGiyim.Renk = btnRenk.BackColor;
                erkekGiyim.Adet = nudAdet.Value;
                listView1.Items.Add(erkekGiyim.SepeteEkle(erkekGiyim));
                Sepet.sepetim.Add(erkekGiyim);
            }
        }
    }
}
