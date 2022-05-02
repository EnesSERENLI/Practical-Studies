using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KimAnlatir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Konu> konuListesi = new List<Konu>() { Konu.Değişkenler, Konu.Operatörler, Konu.Dönüşümler, Konu.TryCatch, Konu.KararYapıları, Konu.Döngüler, Konu.Runtime, Konu.Metotlar, Konu.Encapsulation, Konu.Inheritance, Konu.Polymorphism, Konu.Abstruction, Konu.Enum, Konu.Interface };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Sinif.sinifListesi.Count; i++)
            {
                lstSinif.Items.Add(Sinif.sinifListesi[i]);
            }
            lstKonu.DataSource = konuListesi.ToList();
        }
        object obj;
        private void btnSec_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            Random rnd = new Random();
            Random rnd2 = new Random();
            int rastgeleKisi = rnd.Next(0, lstSinif.Items.Count);
            int rastgeleKonu = rnd2.Next(0, konuListesi.Count);           
            if (lstSinif.Items.Count > 0)
            {
                Sinif secilenKisi = (Sinif)lstSinif.Items[rastgeleKisi];
                foreach (Sinif kisi in Sinif.sinifListesi)
                {
                    if (kisi.Ad == secilenKisi.Ad)
                    {
                        DialogResult dr = MessageBox.Show(kisi.Ad + " " + kisi.Soyad + " - Gelen konu =>" + konuListesi[rastgeleKonu] + "\n" + "Soruyu bildi mi ?", "Puanlamaca", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            lvi.Text = kisi.Ad;
                            lvi.SubItems.Add(kisi.Soyad);
                            lvi.SubItems.Add(konuListesi[rastgeleKonu].ToString());                           
                            kisi.Puan += 5;
                            lvi.SubItems.Add(kisi.Puan.ToString());
                            listView1.Items.Add(lvi);
                            lstSinif.Items.RemoveAt(rastgeleKisi);
                            obj = lvi;
                        }
                        else
                        {
                            lvi.Text = kisi.Ad;
                            lvi.SubItems.Add(kisi.Soyad);
                            lvi.SubItems.Add(konuListesi[rastgeleKonu].ToString());
                            lvi.SubItems.Add(kisi.Puan.ToString());
                            listView1.Items.Add(lvi);
                            lstSinif.Items.RemoveAt(rastgeleKisi);
                            obj= lvi;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seçilecek kimse kalmadı!");
            }
            btn2ndChance.Enabled = true;
        }

        private void btn2ndChance_Click(object sender, EventArgs e)
        {
            //Konuyu beğenmezse sadece 1 kere değiştirme şansı olsun...          
            for (int i = 0; i < 1; i++)
            {
                Random rnd = new Random();
                int rstkonu = rnd.Next(0, konuListesi.Count);
                ListViewItem lvi = (ListViewItem)obj;
                if (lvi.SubItems[2].Text != konuListesi[rstkonu].ToString())
                {
                    MessageBox.Show("Yeni gelen konu => "+konuListesi[rstkonu].ToString());
                    DialogResult dr = MessageBox.Show("Yeni konu mu olsun eskisi mi kalsın ?","Konu seçmece",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        lvi.SubItems[2].Text = konuListesi[rstkonu].ToString();
                        btn2ndChance.Enabled = false;
                    }                    
                }
                else
                {
                    i--;
                    continue;
                }
            }            
        }
    }
}
