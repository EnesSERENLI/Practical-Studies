using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Odev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] isimler = { "AZAD", "SILA", "UMUT", "SARUHAN MERT", "ONUR", "Emre", "ENES", "FURKAN SEMİH", "KAAN", "BAHADIR", "MERT", "BURAK", "AHMET CANER", "TUBA", "MAHMURE", "ARYA", "BERK", "FATİH HOCA" };
        int rastgele;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Ekle butonuna basılınca sınıf listesi kadar buton çıkacak ve her bir butona tıklanınca rastgele bir kişinin ismi messagebox'ta gösterilecek.

            Random rnd = new Random();
            Button btn = new Button();
            int btnText = 0;
            int yatay = 0;
            int dikey = 0;
            string[] name = new string[18];
            int a = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    btn = new Button();
                    rastgele = rnd.Next(0,isimler.Length);
                    
                    if (name.Contains(rastgele.ToString()))
                    {
                        j--;
                        continue;
                    }
                    else
                    {                        
                        name[a] = rastgele.ToString();
                        a++;
                        btn.Name = isimler[rastgele];
                    }                    
                    btnText++;
                    btn.Text = btnText.ToString();
                    btn.Width = 120;
                    btn.Height = 20;
                    btn.Left = yatay;
                    btn.Top = dikey;
                    yatay += 120;
                    this.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
                dikey += 20;
                yatay = 0;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name);
        }
    }
}
