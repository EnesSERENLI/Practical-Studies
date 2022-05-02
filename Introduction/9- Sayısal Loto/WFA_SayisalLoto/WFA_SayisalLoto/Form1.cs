using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Kullanıcı rastegele butonuna basarak 6 sayı ile listbox'ları dolduracak.Her listbox'taki 6 sayı birbirinden farklı olacak. Daha sonra çek butonuna bastıgında yine rastgele 1-50 arası sayılar en üstteki label'lara gelecek.Her biri farklı sayı olacak. Daha sonra her bir listbox'a gelen sayılar, label'lara gelenler ile karşılaştırılaracak. Ardından kaç adet tuttuysa bilgi verilecek.



        private void Form1_Load(object sender, EventArgs e)
        {
            lblBirinciSayi.Text = "0";
            lblIkinciSayi.Text = "0";
            lblUcuncuSayi.Text = "0";
            lblDorduncuSayi.Text = "0";
            lblBesinciSayi.Text = "0";
            lblAltinciSayi.Text = "0";
            btnCek.Enabled = false;
        }

        //Listbox'lara rastgele sayı gönderme
        private void btnRastgele_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rastgele;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ListBox)
                {
                    ListBox lst = (ListBox)ctrl;
                    lst.Items.Clear();
                    for (int i = 0; i < 6; i++)
                    {
                        rastgele = rnd.Next(1, 50);
                        if (lst.Items.Contains(rastgele))
                        {
                            i--;
                            continue;
                        }
                        else
                        {
                            lst.Items.Add(rastgele);
                        }
                    }
                }
            }
            btnCek.Enabled = true;
        }

        //Label'lara rastege farklı sayılar atma
        private void btnCek_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] sayilar = new int[6];
            for (int i = 0; i < 6; i++)
            {
                int rst = rnd.Next(1, 50);
                if (sayilar.Contains(rst))
                {
                    i--;
                    continue;
                }
                else
                {
                    sayilar[i] = rst;
                }
            }
            lblBirinciSayi.Text = sayilar[0].ToString();
            lblIkinciSayi.Text = sayilar[1].ToString();
            lblUcuncuSayi.Text = sayilar[2].ToString();
            lblDorduncuSayi.Text = sayilar[3].ToString();
            lblBesinciSayi.Text = sayilar[4].ToString();
            lblAltinciSayi.Text = sayilar[5].ToString();

            //Kontrol işlemi. --Farklı bir button ile de yapılabilirdi.. 
            int tutan1 = 0;
            int tutan2 = 0;
            int tutan3 = 0;
            int tutan4 = 0;
            int tutan5 = 0;
            int tutan6 = 0;
            int tutan7 = 0;
            int tutan8 = 0;

            listBox1.SelectedItem = null;
            listBox2.SelectedItem = null;
            listBox3.SelectedItem = null;
            listBox4.SelectedItem = null;
            listBox5.SelectedItem = null;
            listBox6.SelectedItem = null;
            listBox7.SelectedItem = null;
            listBox8.SelectedItem = null;


            for (int i = 0; i < 6; i++)
            {
                if (listBox1.Items.Contains(sayilar[i]))
                {
                    tutan1++;                   
                    listBox1.SelectedItem = sayilar[i];
                }
                
                if (listBox2.Items.Contains(sayilar[i]))
                {
                    tutan2++;                    
                    listBox2.SelectedItem = sayilar[i];
                }
               
                if (listBox3.Items.Contains(sayilar[i]))
                {
                    tutan3++;                   
                    listBox3.SelectedItem = sayilar[i];
                }
              
                if (listBox4.Items.Contains(sayilar[i]))
                {
                    tutan4++;                    
                    listBox4.SelectedItem = sayilar[i];
                }
               
                if (listBox5.Items.Contains(sayilar[i]))
                {
                    tutan5++;                    
                    listBox5.SelectedItem = sayilar[i];
                }
             
                if (listBox6.Items.Contains(sayilar[i]))
                {
                    tutan6++;                   
                    listBox6.SelectedItem = sayilar[i];
                }
                
                if (listBox7.Items.Contains(sayilar[i]))
                {
                    tutan7++;                  
                    listBox7.SelectedItem = sayilar[i];
                }
             
                if (listBox8.Items.Contains(sayilar[i]))
                {
                    tutan8++;                   
                    listBox8.SelectedItem = sayilar[i];
                }
              
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    Label lbl = (Label)ctrl;
                    lbl.Visible = true;
                }
            }

            //6 tutturan olursa milyoner olduğunu bilsin xD
            lblTutanBir.Text = tutan1.ToString() + " Adet sayı tuttu!";
            if (tutan1 == 6)
            {
                MessageBox.Show("Hell Yeahh!! Artık milyonersin dostum xD");
                lblTutanBir.ForeColor = Color.Green;
            }
            lblTutanIki.Text = tutan2.ToString() + " Adet sayı tuttu!";
            if (tutan2 == 6)
            {
                MessageBox.Show("Hell Yeahh!! Artık milyonersin dostum xD");
                lblTutanIki.ForeColor = Color.Green;
            }
            lblTutanUc.Text = tutan3.ToString() + " Adet sayı tuttu!";
            if (tutan3 == 6)
            {
                MessageBox.Show("Hell Yeahh!! Artık milyonersin dostum xD");
                lblTutanUc.ForeColor = Color.Green;
            }
            lblTutanDort.Text = tutan4.ToString() + " Adet sayı tuttu!";
            if (tutan4 == 6)
            {
                MessageBox.Show("Hell Yeahh!! Artık milyonersin dostum xD");
                lblTutanDort.ForeColor = Color.Green;
            }
            lblTutanBes.Text = tutan5.ToString() + " Adet sayı tuttu!";
            if (tutan5 == 6)
            {
                MessageBox.Show("Hell Yeahh!! Artık milyonersin dostum xD");
                lblTutanBes.ForeColor = Color.Green;
            }
            lblTutanAlti.Text = tutan6.ToString() + " Adet sayı tuttu!";
            if (tutan6 == 6)
            {
                MessageBox.Show("Hell Yeahh!! Artık milyonersin dostum xD");
                lblTutanAlti.ForeColor = Color.Green;
            }
            lblTutanYedi.Text = tutan7.ToString() + " Adet sayı tuttu!";
            if (tutan7 == 6)
            {
                MessageBox.Show("Hell Yeahh!! Artık milyonersin dostum xD");
                lblTutanYedi.ForeColor = Color.Green;
            }
            lblTutanSekiz.Text = tutan8.ToString() + " Adet sayı tuttu!";
            if (tutan8 == 6)
            {
                MessageBox.Show("Hell Yeahh!! Artık milyonersin dostum xD");
                lblTutanSekiz.ForeColor = Color.Green;
            }
        }
    }
}
