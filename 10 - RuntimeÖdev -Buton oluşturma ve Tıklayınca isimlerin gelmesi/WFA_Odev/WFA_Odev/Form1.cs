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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //10 adet stun ve 10 adet satır oluşacak. Buttonlardan oluşacak. Her butonun üstünde kaçıncı satır ve stunda olduğu yazacak. Ayrıca ekran açıldığında otomatik olarak boyutunu ayarlayacak.

            string format;
            int yatay = 0;
            int dikey = 0;
            Button btn = new Button();
            
            for (int i = 1; i <= 10; i++)
            {
                
                for (int j = 1; j <= 10; j++)
                {
                    
                    btn = new Button();
                    format = string.Format("{0}x{1}", i, j);
                    btn.Text = format;
                    btn.Width = 120;
                    btn.Height = 20;
                    btn.Left = yatay;
                    btn.Top = dikey;
                    yatay += 120;
                    this.Controls.Add(btn);
                    
                }
                dikey += 20;
                yatay = 0;
            }
            this.Width = (btn.Width*10)+20;
            this.Height = btnEkle.Bottom +50;
        }
    }
}
