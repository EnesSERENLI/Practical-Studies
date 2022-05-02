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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            //bir nesneyi hareket ettirmek istersek sol (left) ve altına (bottom) değer ataması gerçekleştirilir. sağ(right) ve üst(top) değerleri sadece okunabilir. Read only.
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //atlar finish çizgisine doğru hareket edecekler.
            //Ancak hangi atın ilk önce finish çizgisine geleceğiniz bilemeyeceğiz.
            //Atları koşturma
           
            pbAt1.Left += rnd.Next(10, 30);
            pbAt2.Left += rnd.Next(10, 30);
            pbAt3.Left += rnd.Next(10, 30);

            //KAzanma Durumları
          
            if (pbAt1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("1. At kazandı!!+\n+ Tekrar oynamak ister misin ?", "Oyun bitti.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 9;
                    pbAt2.Left = 9;
                    pbAt3.Left = 9;
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pbAt2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("2. At kazandı!!+\n+ Tekrar oynamak ister misin ?", "Oyun bitti.", MessageBoxButtons.YesNo, MessageBoxIcon.Information); //MessageBox özelliklerinden yaptık.
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 9;
                    pbAt2.Left = 9;
                    pbAt3.Left = 9;
                }
                else
                {
                    Application.Exit(); // uygulamayı kapat
                }

            }
            else if (pbAt3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("3. At kazandı!!+\n+ Tekrar oynamak ister misin ?", "Oyun bitti.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 9;
                    pbAt2.Left = 9;
                    pbAt3.Left = 9;
                }
                else
                {
                    Application.Exit();
                }

                //Spiker
                
                
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
            // Uygulama start olduğunda 3 farklı zemin renginden bir tanesi tanımlansın bunlar; kahverengi,yeşil ve gri olsun
            //Zemin rengi kahveregi ise 1. at kazansın
            //yeşil ise 2. at kazansın
            //gri de 3. at kazansın
            //yatır butonuna tıklanmadan yarış başlamayacak.
        }
    }
}
