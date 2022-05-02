using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        decimal puan1 = 500;
        decimal puan2 = 500;
        decimal toplamPara;
        decimal cekilenPara1;
        decimal cekilenPara2;
        decimal yatirilanPara1;
        decimal yatirilanPara2;

        private void Form2_Load(object sender, EventArgs e)
        {
            btnZar1.Enabled = false;
            btnZar2.Enabled = false;    
            lblBakiyeBir.Text = puan1.ToString();
            lblBakiyeIki.Text = puan2.ToString();
            btnOrtayaYatirIki.Enabled = false;

        }

        private void btnOrtayaYatirBir_Click(object sender, EventArgs e)
        {
            if (nudYatirBir.Value <= Convert.ToDecimal(lblBakiyeBir.Text))
            {
                toplamPara += nudYatirBir.Value;
                lblToplamPara.Text = toplamPara.ToString();
                lblBakiyeBir.Text = (Convert.ToDecimal(lblBakiyeBir.Text) - nudYatirBir.Value).ToString();
                btnOrtayaYatirIki.Enabled=true;
            }
                                        
            else if (nudYatirBir.Value >= Convert.ToDecimal(lblBakiyeBir.Text))
            {
                MessageBox.Show("Puanınız Yetersiz..!");
            }
         
        }

        private void btnOrtayaYatirIki_Click(object sender, EventArgs e)
        {
            if (nudYatirIki.Value <= Convert.ToDecimal(lblBakiyeIki.Text))
            {
                toplamPara += nudYatirIki.Value;
                lblToplamPara.Text = toplamPara.ToString();
                lblBakiyeIki.Text = (Convert.ToDecimal(lblBakiyeIki.Text) - nudYatirIki.Value).ToString();
                btnZar1.Enabled = true;
               
            }
            else
            {
                MessageBox.Show("Puanınız Yetersiz..!");
            }
                      
        }

        private void btnZar1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rastgele1 = rnd.Next(1, 7);
            lblZar1.Text = rastgele1.ToString();
            listBox3.Items.Add("1. Oyuncu Zar Attı.. Gelen zar => "+ rastgele1);
            btnZar1.Enabled = false;
            btnZar2.Enabled = true;
        }

        private void btnZar2_Click(object sender, EventArgs e)
        {
            Random rnd2 = new Random();
            int rastgele2 = rnd2.Next(1, 7);
            lblZar2.Text = rastgele2.ToString();
            listBox3.Items.Add("2. Oyuncu Zar Attı.. Gelen zar => "+rastgele2);
            btnZar2.Enabled = false;

            
            if (Convert.ToInt32(lblZar1.Text) > Convert.ToInt32(lblZar2.Text))
            {
                lblSonuc.Text = "1. Oyuncu kazandı.. Toplam puanlar 1. oyuncuya aktarıldı.";
                lblBakiyeBir.Text = (Convert.ToDecimal(lblToplamPara.Text) + Convert.ToDecimal(lblBakiyeBir.Text)).ToString();
                listBox3.Items.Add("1. Oyuncu Kazandı, kazanılan toplam puan => "+toplamPara);
                listBox3.Items.Add("-------------------------------------------------------------------------------");
                listBox1.Items.Add("1. Oyuncunun punanına " + toplamPara + " eklendi.");
                toplamPara = 0;
                lblToplamPara.Text = toplamPara.ToString();
                btnOrtayaYatirIki.Enabled = false;
            }
            else if (Convert.ToInt32(lblZar1.Text) == Convert.ToInt32(lblZar2.Text))
            {
                lblSonuc.Text = "Berabere kaldınız.. Tekrar zar atın..";
                btnZar1.Enabled = true;
                btnZar2.Enabled = true;
            }
            else
            {
                lblSonuc.Text = "2. Oyuncu kazandı.. Toplam puanlar 2. oyuncuya aktarıldı.";
                lblBakiyeIki.Text = (Convert.ToDecimal(lblToplamPara.Text) + Convert.ToDecimal(lblBakiyeIki.Text)).ToString();
                listBox3.Items.Add("2. Oyuncu Kazandı, kazanılan toplam puan => " + toplamPara);
                listBox3.Items.Add("-------------------------------------------------------------------------------");                
                listBox2.Items.Add("2. Oyuncunun punanına " + toplamPara + " eklendi.");
                toplamPara = 0;
                lblToplamPara.Text = toplamPara.ToString();
                btnOrtayaYatirIki.Enabled = false;   
            }
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            cekilenPara1 = nudParaCek.Value;
            if(cekilenPara1 > Convert.ToDecimal(lblBakiyeBir.Text))
            {
                MessageBox.Show("Bakiyenizden fazla para çekemezsiniz.!");
            }
            else
            {
                lblBakiyeBir.Text = ((Convert.ToDecimal(lblBakiyeBir.Text)) - cekilenPara1).ToString();
                listBox1.Items.Add("1 . Oyuncu para çekti.. Çekilen para => " + cekilenPara1);
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            yatirilanPara1 = nudParaYatir.Value;
            if (yatirilanPara1 < 1 )
            {
                MessageBox.Show("En az 1 TL yatırabilirsiniz.!");
            }
            else
            {
                lblBakiyeBir.Text = ((Convert.ToDecimal(lblBakiyeBir.Text)) + yatirilanPara1).ToString();
                listBox1.Items.Add("1 . Oyuncu para yatırdı.. Yatırılan para => " + yatirilanPara1);
            }
        }

        private void btnParaCek2_Click(object sender, EventArgs e)
        {
            cekilenPara2 = nudParaCek2.Value;
            if (cekilenPara2 > Convert.ToDecimal(lblBakiyeIki.Text))
            {
                MessageBox.Show("Bakiyenizden fazla para çekemezsiniz.!");
            }
            else
            {
                lblBakiyeIki.Text = ((Convert.ToDecimal(lblBakiyeIki.Text)) - cekilenPara2).ToString();
                listBox2.Items.Add("2 . Oyuncu para çekti.. Çekilen para => " + cekilenPara2);
            }
        }

        private void btnParaYatir2_Click(object sender, EventArgs e)
        {
            yatirilanPara2 = nudParaYatir2.Value;
            if (yatirilanPara2 < 1)
            {
                MessageBox.Show("En az 1 TL yatırabilirsiniz.!");
            }
            else
            {
                lblBakiyeIki.Text = ((Convert.ToDecimal(lblBakiyeIki.Text)) + yatirilanPara2).ToString();
                listBox2.Items.Add("2 . Oyuncu para yatırdı.. Yatırılan para => " + yatirilanPara2);
            }
        }
    }
}
