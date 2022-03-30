using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string[] renk = { "brown", "greenyellow", "gray" }; // Bunu tanımlamayı görmedik !! 
        decimal yatir1;
        decimal yatir2;
        decimal yatir3;

        private void Form2_Load(object sender, EventArgs e)
        {
            //int sayi = rnd.Next(renk.Length);
            //this.BackColor = Color.FromName(renk[sayi]); FromName string bir ifade alabiliyor ? bunuda görmedik.. 
            
            int rastgele=rnd.Next(1,4);
            if (rastgele==1)
            {
                this.BackColor = Color.Brown;
                lblYatir1.Text = "1,20";
            }
            else if (rastgele == 2)
            {
                this.BackColor = Color.GreenYellow;
                lblYatir2.Text = "1,20";
            }
            else if(rastgele == 3)
            {
                this.BackColor = Color.Gray;
                lblYatir3.Text = "1,20";
            }
            btnBaslat.BackColor = Color.Yellow;
            btnBaslat.Enabled = false;
               
        }
        private void btnYatir1_Click(object sender, EventArgs e)
        {
            yatir1 = nudYatir1.Value;
            btnBaslat.Enabled = true;
            btnBaslat.BackColor = Color.Green;
        }
        private void btnYatir2_Click(object sender, EventArgs e)
        {
            yatir2 = nudYatir2.Value;
            btnBaslat.Enabled = true;
            btnBaslat.BackColor = Color.Green;
        }
        private void btnYatir3_Click(object sender, EventArgs e)
        {
            yatir3 = nudYatir3.Value;
            btnBaslat.Enabled = true;
            btnBaslat.BackColor = Color.Green;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbAt1.Left += rnd.Next(10, 30);
            pbAt2.Left += rnd.Next(10, 30);
            pbAt3.Left += rnd.Next(10, 30);

            if (this.BackColor == Color.Brown)
            {
                pbAt1.Left += rnd.Next(0, 8);
                
                if(pbAt1.Right >= lblFinish.Left)
                {
                    timer1.Stop();
                    lblToplam.Text = (Convert.ToDecimal(lblYatir1.Text)*yatir1).ToString();
                    MessageBox.Show("1. At kazandı!!");
                      
                }

            }
            else if (this.BackColor == Color.GreenYellow)
            {

                pbAt2.Left += rnd.Next(0, 8);
                if(pbAt2.Right >= lblFinish.Left)
                {
                    timer1.Stop();
                    lblToplam.Text = (Convert.ToDecimal(lblYatir2.Text) * yatir2).ToString();
                    MessageBox.Show("2. At kazandı!!");
                }
            }
            else if (this.BackColor == Color.Gray)
            {
                pbAt3.Left += rnd.Next(0, 8);
                if (pbAt3.Right >= lblFinish.Left)
                {
                    timer1.Stop();
                    lblToplam.Text = (Convert.ToDecimal(lblYatir2.Text) * yatir2).ToString();
                    MessageBox.Show("3. At kazandı!!");
                }
            }
            if (pbAt1.Right > pbAt2.Right && pbAt1.Right > pbAt3.Right)
            {

                lblSpiker.Text = "1. At önde";
            }
            else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            {
                lblSpiker.Text = "2. At önde";
            }
            else if (pbAt3.Right > pbAt1.Right && pbAt3.Right > pbAt2.Right)
            {
                lblSpiker.Text = "3. At önde";
            }
        }

       
    }
}
