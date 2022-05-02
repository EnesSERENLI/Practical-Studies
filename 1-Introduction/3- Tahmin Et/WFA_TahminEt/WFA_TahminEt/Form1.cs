using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 1;
        int b = 11;
        int level = 1;
        int tahmin;
        int tutulanSayi;
        int hak = 5;
        Random rnd = new Random();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblSonuc.Text = level+ ". seviyedesiniz " + a + " ile " + (b-1) + " arasında bir sayı giriniz.";
            tutulanSayi = rnd.Next(a, b);
            lblTutulan.Text = tutulanSayi.ToString();
            //this.Text = tutulanSayi.ToString(); - Burada this bulunduğı scopu temsilen atanmıştır. Form1 içine yazdık.başlığı değiştirebiliriz.
        }
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            try
            {
                tahmin = Convert.ToInt32(txtTahmin.Text);
               
                if (tahmin == tutulanSayi)
                {
                    lblSonuc.Text = "Tebrikler doğru tahmin!!";
                    lblSonuc.ForeColor = Color.Green;
                    hak = 5;
                    lblHak.Text = hak.ToString();
                    listBox1.Items.Add("Tahmin Edilen=> " + tahmin + " Tutulan=> " + tutulanSayi + " Seviye=> " + level);
                    b += 10;
                    tutulanSayi = rnd.Next(a, b);
                    level++;
                    lblLevel.Text = level.ToString();
                    lblTutulan.Text = tutulanSayi.ToString();

                }
                else if (tahmin > tutulanSayi)
                {
                    lblSonuc.Text = "Lütfen daha küçük bir sayı giriniz";
                    lblSonuc.ForeColor = Color.Blue;
                    hak--;
                    lblHak.Text = hak.ToString();
                    listBox1.Items.Add("Tahmin Edilen=> " + tahmin + " Seviye=> " + level);
                    if (hak == 0)
                    {
                        btnTahmin.Enabled = false;
                        lblSonuc.ForeColor = Color.Red;
                        lblSonuc.Text = "Başka tahmin hakkınız kalmadı!!";
                    }
                }
                else if (tahmin < tutulanSayi)
                {
                    lblSonuc.Text = "Lütfen daha büyük bir sayı giriniz";
                    lblSonuc.ForeColor = Color.Blue;
                    hak--;
                    lblHak.Text = hak.ToString();
                    listBox1.Items.Add("Tahmin Edilen=> " + tahmin + " Seviye=> " + level);
                    if (hak == 0)
                    {
                        btnTahmin.Enabled = false;
                        lblSonuc.ForeColor = Color.Red;
                        lblSonuc.Text = "Başka tahmin hakkınız kalmadı!!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Sayı Giriniz..!");
            }
                      
        }

        private void txtTahmin_MouseHover(object sender, EventArgs e)
        {
            lblSonuc.Text = level + ". seviyedesiniz " + a + " ile " + (b - 1) + " arasında bir sayı giriniz.";
            lblSonuc.ForeColor = Color.Black;
        }
    }
}
