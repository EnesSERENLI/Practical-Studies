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
    public partial class CepTelefonu : Form
    {
        public CepTelefonu()
        {
            InitializeComponent();
        }
        private void CepTelefonu_Load(object sender, EventArgs e)
        {
            foreach (Telefon tel in Telefon.telefonListesi)
            {
                if (!cmbMarka.Items.Contains(tel.Marka))
                {
                    cmbMarka.Items.Add(tel.Marka);
                }
            }
            foreach (RAM ram in RAM.ramListesi)
            {
                cmbRam.Items.Add(ram);
            }
            foreach (HafizaKarti kart in HafizaKarti.hafizaKartiListesi)
            {
                cmbHafiza.Items.Add(kart);
            }
        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.SelectedIndex = -1;
            cmbModel.Items.Clear();
            foreach (Telefon tel in Telefon.telefonListesi)
            {
                if (cmbMarka.SelectedItem == tel.Marka)
                {
                    cmbModel.Items.Add(tel);
                }
            }
        }
        #region Fazlalık
        //-----------------------------------------------------------------------------------
        //private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(cmbModel.SelectedIndex !=-1)
        //    foreach (Telefon tel in Telefon.telefonListesi)
        //    {
        //        if (cmbMarka.SelectedItem.ToString() == tel.Marka && cmbModel.SelectedItem.ToString() == tel.Model)
        //        {
        //            lblFiyat.Text = tel.Fiyat.ToString("C2");
        //            return;
        //        }
        //    }
        //}

        //private void cmbRam_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbMarka.SelectedIndex != -1 && cmbModel.SelectedIndex != -1)
        //    {
        //        foreach (Telefon tel in Telefon.telefonListesi)
        //        {
        //            if (cmbMarka.SelectedItem.ToString() == tel.Marka && cmbModel.SelectedItem.ToString() == tel.Model)
        //            {
        //                foreach (RAM ram in RAM.ramListesi)
        //                {
        //                    RAM r = cmbRam.SelectedItem as RAM;
        //                    if (ram.Kapasite == r.Kapasite)
        //                    {
        //                        tel.RAM = ram;
        //                        lblFiyat.Text = (tel.Fiyat + ram.Fiyat).ToString("C2");
        //                        return;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private void cmbHafiza_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbMarka.SelectedIndex != -1 && cmbModel.SelectedIndex != -1)
        //    {
        //        foreach (Telefon tel in Telefon.telefonListesi)
        //        {
        //            if (cmbMarka.SelectedItem.ToString() == tel.Marka && cmbModel.SelectedItem.ToString() == tel.Model)
        //            {

        //                foreach (HafizaKarti kart in HafizaKarti.hafizaKartiListesi)
        //                {
        //                    HafizaKarti hk = cmbHafiza.SelectedItem as HafizaKarti;
        //                    if (kart.HafizaKart == hk.HafizaKart)
        //                    {
        //                        tel.Hafiza = kart;
        //                        lblFiyat.Text = (tel.Fiyat + tel.RAM.Fiyat + kart.Fiyat).ToString("C2");
        //                        return;
        //                    }
        //                }
        //            }
        //        }
        //    }            
        //}

        #endregion
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex != -1 && cmbModel.SelectedIndex != -1 && cmbRam.SelectedIndex != -1 && cmbHafiza.SelectedIndex != -1)
            {
                Telefon telefon = cmbModel.SelectedItem as Telefon;
                telefon.RAM = (RAM)cmbRam.SelectedItem;
                telefon.Hafiza = (HafizaKarti)cmbHafiza.SelectedItem;                
                telefon.Adet = nudAdet.Value;               
                listView1.Items.Add(telefon.SepeteEkle(telefon));
                Sepet.sepetim.Add(telefon);
                GirisForm.Sifirla(groupBox1);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex != -1 && cmbModel.SelectedIndex !=-1 && cmbRam.SelectedIndex != -1 && cmbHafiza.SelectedIndex != -1)
            {
                Telefon telefon = (Telefon)cmbModel.SelectedItem;
                telefon.RAM = (RAM)cmbRam.SelectedItem;
                telefon.Hafiza = (HafizaKarti)cmbHafiza.SelectedItem;
                telefon.Adet = nudAdet.Value;
                lblFiyat.Text = telefon.TutarHesapla(telefon).ToString("C2");
            }           
        }
    }
}
