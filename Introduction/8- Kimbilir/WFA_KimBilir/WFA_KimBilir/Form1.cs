using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KimBilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = { "AZAD", "SILA", "UMUT", "SARUHAN MERT", "ONUR", "Emre", "ENES", "FURKAN SEMİH", "KAAN", "BAHADIR", "MERT", "BURAK", "AHMET CANER", "TUBA", "MAHMURE", "ARYA", "BERK" };
        string[] soyisimler = { "MAJIDLI", "ŞİRİN", "YILBAŞ", "DEMİRAY", "DOĞRU", "Bektaşoğlu", "SERENLİ", "GÜNEŞ", "ÜNAL", "ARDA", "ÇINAR", "UYSAL", "TAI", "BUĞDAY KARADUT", "OKAN", "KAPIKIRAN", "BASAT" };
        string format;
        int secilen;
        int sayac = 30;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                format = string.Format("{0} {1}", isimler[i], soyisimler[i]);
                listBox1.Items.Add(format);
            }
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                int puan = 0;
                secilen = rnd.Next(0, isimler.Length);
                for (int i = 0; i < 1; i++)
                {
                    for (int a = 0; a < listBox1.Items.Count; a++)
                    {
                        if (listBox1.Items[a].ToString() == isimler[secilen] + " " + soyisimler[secilen])
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = isimler[secilen];
                            lvi.SubItems.Add(soyisimler[secilen]);
                            lvi.SubItems.Add(puan.ToString());
                            listView1.Items.Add(lvi);                            
                            DialogResult dr = MessageBox.Show("Soruyu Bildi mi ?", "Puanlamaca", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dr == DialogResult.Yes)
                            {
                                puan = 5;
                                lvi.SubItems[2].Text = puan.ToString();
                                listBox1.Items.RemoveAt(a);
                                timer1.Stop();
                                sayac = 30;
                                lblSayac.Text = sayac.ToString();
                                return;
                            }
                            if (dr == DialogResult.No)
                            {
                                puan = 0;
                                lvi.SubItems[2].Text = puan.ToString();
                                listBox1.Items.RemoveAt(a);
                                timer1.Stop();
                                sayac = 30;
                                lblSayac.Text = sayac.ToString();
                                return;
                            }
                        }                     
                    }
                    if (listBox1.Items.Count == 0)
                    {
                        MessageBox.Show("Seçilecek kimse kalmadı!");
                        timer1.Stop();
                        return;
                    }
                    i--;
                    secilen = rnd.Next(0, isimler.Length);
                    continue;
                }
            }              
            catch (Exception ex)
            {
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Stop();
                lblSayac.Text = sayac.ToString();
            }
        }
    }
}
