using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TopSektirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hizYatay = 30;
        int hizDikey = 30;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.ToString());
            //MessageBox.Show(e.KeyCode.ToString()); //basmış oldugumuz tusu getiriyor.
           /* 
            bool isA = e.KeyCode == Keys.A;
            if (isA)
            {
                MessageBox.Show("A tusu aktif");
            }
           */

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pbTop.Left -= hizYatay;
                    break;
                case Keys.Right:
                    pbTop.Left += hizYatay;
                    break;
                case Keys.Up:
                    pbTop.Top -= hizDikey;
                    break;
                case Keys.Down:
                    pbTop.Top += hizDikey;
                    break;
                case Keys.D:
                    timer1.Start();                    
                    break;
                case Keys.S:
                    timer1.Stop();
                    timer2.Stop();
                    break;
                case Keys.T:
                    timer2.Start();
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbTop.Left += hizYatay;
            if (pbTop.Right >= this.Right)
            {
                hizYatay = -30;
                pbTop.Left += hizYatay;
            }
            if (pbTop.Left <= this.Left)
            {
                hizYatay = 30;
                pbTop.Left += hizYatay;
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbTop.Top -= hizDikey;

            if (pbTop.Top <= this.Top)
            {
                hizDikey = -30;
                pbTop.Top -= hizDikey;
            }
            if (pbTop.Bottom >= this.Bottom)
            {
                hizDikey = 30;
                pbTop.Top -= hizDikey;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bunu yapmamın sebebi formu en sol ve üstte açmasını sağlamak. Çünkü topun solu, formun yerini değiştirince, formun solundan daha en başka küçük olabiliyor. Bunun önüne geçmek istedim...
            this.Left = 0; 
            this.Top = 0;
        }
    }
}
