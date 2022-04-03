using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRandevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Arrays..
        string[] randevuSaatleri = { "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30" };
        private void Form1_Load(object sender, EventArgs e)
        {
            //Branş ekle butonuna basınca bir branş eklenecek. Aynı branş tekrar yazılırsa eklenmeyecek. Doktor ekle butonuna basınca Branşı ile beraber doktor eklenecek. Hiçbirşey yazılmadan butonlara basılırsa hiçbirşey eklenmeyecek.
            //Randevu alırken Branş seçilince o Branşa eklenmiş doktorlar listelenecek.
            //Datetimepicker geçmiş tarih seçilemeyecek.
            //Tarih seçince runtimede flowpanel içine randevu butonları gelecek.Butona tıklayınca Evet Hayır sorusu gelecek.Evet seçilirse rengı kırmızı olacak ve bir daha tıklanmayacak.
        }
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            if (txtBrans.Text != String.Empty)
            {
                Brans brans = new Brans(txtBrans.Text.ToUpper());
                brans.branslar.Add(brans);
                foreach (Brans br in brans.branslar)
                {
                    if (!cmbRandevuBrans.Items.Contains(br.BransAd))
                    {
                        cmbBrans.Items.Add(br);
                        cmbRandevuBrans.Items.Add(br.BransAd);
                    }
                    else
                    {
                        MessageBox.Show("Bu Branş daha önce tanımlanmış.!");
                    }
                }
                txtBrans.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Lütfen bir Branş adı giriniz.!");
            }
        }
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            if (txtDoktorAd.Text != String.Empty && cmbBrans.SelectedIndex != -1)
            {
                Brans brans = (Brans)cmbBrans.SelectedItem;
                Doktor doktor = new Doktor() { DoktorAd = txtDoktorAd.Text, DoktorBrans = brans };
                Doktor.doktorlarListesi.Add(doktor);
                //List<Doktor> doktorlarListesi = new List<Doktor>() { new Doktor { DoktorAd = txtDoktorAd.Text, DoktorBrans = brans } }; --Yukarıdaki 3 satır yerine bunu yazabilirim.. Ancak listeyi ben Doktor class'ında tanımladım.
                txtDoktorAd.Text = String.Empty;
                cmbBrans.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Doktor ve Branş bölümlerini doldurduğunuzdan emin olunuz.!");
            }
        }
        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRandevuDoktor.SelectedIndex = -1;
            cmbRandevuDoktor.Items.Clear();
            foreach (Doktor dr in Doktor.doktorlarListesi)
            {
                if (dr.DoktorBrans.ToString() == cmbRandevuBrans.SelectedItem.ToString())
                {
                    cmbRandevuDoktor.Items.Add(dr);
                }
            }
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (dtpTarih.Value >= DateTime.Today)
            {
                for (int i = 0; i < randevuSaatleri.Length; i++)
                {
                    Button btn = new Button();
                    btn.Text = randevuSaatleri[i];
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
            else
            {
                MessageBox.Show("Geçmiş tarihe randevu alamazsınız. Lütfen ileri bir tarih seçiniz!");
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DialogResult dr = MessageBox.Show("Randevu oluşturmak isteğinize emin misiniz ?", "Randevu Oluşturma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string brans = (string)cmbRandevuBrans.SelectedItem;
                Doktor doktor = (Doktor)cmbRandevuDoktor.SelectedItem;
                Randevu randevu = new Randevu(txtRandevuAd.Text, txtRandevuSoyad.Text, txtRandevuTckn.Text, doktor, brans, dtpTarih.Value);
                Randevu.randevuListesi.Add(randevu); // Tüm randevuları kayıt altına almak için yazıldı. İstersek buradan kim ne zaman randevu almış görebiliriz.
                btn.BackColor = Color.Red;
                btn.Enabled = false;
                MessageBox.Show("Randevunuz oluşturuldu. Randevu Tarihi: " + dtpTarih.Value.ToShortDateString() + " Saat: " + btn.Text);
            }
        }
    }
}
