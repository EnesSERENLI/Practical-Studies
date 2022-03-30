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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Barbut oyunu
        //1. zar at butonuna basınca 1. zar 1 ve 6 arasında rastgele sayı verecek.
        //2. zar at butonuna basınca 2. zar 1 ve 6 arasında rastgele sayı verecek.
        //Büyük zarı atan label da kazanmış olarak gösterilecek.
        private void Form1_Load(object sender, EventArgs e)
        {
            btnZar2.Enabled = false;

        }
        private void btnZar1_Click(object sender, EventArgs e)
        {
            //instance => örnek alma (bir nesnenin ram üzerine bir örneğini alma işlemi.)
            Random rnd = new Random(); //rnd isim verme - new ile de yeni kopyamız oldu.
            //int rastgeleSayi = rnd.Next(); rastege negatif olamayan int sayı verir
            //int rastgele=rnd.Next(10); rast gele 0 ile 10 arasında sayı verir
            //MessageBox.Show(rastgele.ToString());

            //Oluşturulacak değer 1 ile 6 arasında olması gerekiyor.

            int rastgele = rnd.Next(1, 7);   //C# sayma işlemine 0'dan başlar. 1 ile 6 arasını istiyorsak 1'i alacak 7'yi almayacak. Min değerin kendisini max değerin 1 azını alır.
            lblZar1.Text = rastgele.ToString();
            btnZar2.Enabled=true;
            btnZar1.Enabled = false;
            
        }

        private void btnZar2_Click(object sender, EventArgs e)
        {
            btnZar1.Enabled = false;
            Random rnd2 = new Random();
            int rastgele2 = rnd2.Next(1, 7);
            lblZar2.Text = rastgele2.ToString();
            btnZar2.Enabled = false;
           

            if (Convert.ToInt32(lblZar1.Text) > Convert.ToInt32(lblZar2.Text))
            {
                lblSonuc.Text = "1. Oyuncu kazandı..";
            }
            else if (Convert.ToInt32(lblZar1.Text) == Convert.ToInt32(lblZar2.Text))
            {
                lblSonuc.Text = "Berabere kaldınız..";
                btnZar1.Enabled = true;
                btnZar2.Enabled = true;
            }
            else
            {
                lblSonuc.Text = "2. Oyuncu kazandı..";
            }
        }
    }
}
