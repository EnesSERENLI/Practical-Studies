using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_FutbolTakimi
{
    public partial class FootballAreaForm : Form
    {
        public FootballAreaForm()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            foreach (Control ctrl in this.Controls.OfType<Button>().ToList()) //Oftype silinmesi gereken control'ü filtreledik.
            {
                this.Controls.Remove(ctrl);
            }
        }
        void Kaleci()
        {
            foreach (Futbolcu kaleci in Futbolcu.manchesterCity)
            {
                Button btn = new Button();
                switch (kaleci.Ad)
                {
                    case "Ederson":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(12, 233);
                        btn.Text = kaleci.FormaNumarasi;
                        btn.Name = kaleci.Ad + " " + kaleci.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                }
            }
        }
        void DortluDef()
        {
            foreach (Futbolcu defans in Futbolcu.manchesterCity)
            {
                Button btn = new Button();
                switch (defans.Ad)
                {
                    case "Kyle":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(176, 58);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Ruben":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(114, 164);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "John":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(114, 293);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Benjamin":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(176, 420);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                }
            }
        }
        void DortluOrtaSaha()
        {
            foreach (Futbolcu ortaSaha in Futbolcu.manchesterCity)
            {
                Button btn = new Button();
                switch (ortaSaha.Ad)
                {
                    case "Kevin":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(344, 155);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Phil":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(344, 317);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Raheem":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(450, 49);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Jack":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(450, 420);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                }
            }
        }
        void IkiliForvet()
        {
            foreach (Futbolcu forvet in Futbolcu.manchesterCity)
            {
                Button btn = new Button();
                switch (forvet.Ad)
                {
                    case "Gabriel":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(659, 164);
                        btn.Text = forvet.FormaNumarasi;
                        btn.Name = forvet.Ad + " " + forvet.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Riyad":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(659, 303);
                        btn.Text = forvet.FormaNumarasi;
                        btn.Name = forvet.Ad + " " + forvet.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                }
            }
        }
        void UcluDef()
        {
            foreach (Futbolcu defans in Futbolcu.manchesterCity)
            {
                Button btn = new Button();
                switch (defans.Ad)
                {
                    case "Kyle":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(114, 73);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Ruben":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(114, 224);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "John":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(114, 385);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                }
            }
        }
        void BesliOrtasaha()
        {
            foreach (Futbolcu ortaSaha in Futbolcu.manchesterCity)
            {
                Button btn = new Button();
                switch (ortaSaha.Ad)
                {
                    case "Benjamin":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(336, 150);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Kevin":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(336, 322);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Phil":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(440, 49);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Raheem":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(440, 422);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Jack":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(539, 236);
                        btn.Text = ortaSaha.FormaNumarasi;
                        btn.Name = ortaSaha.Ad + " " + ortaSaha.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                }
            }
        }
        void UcluOrtaSaha()
        {
            foreach (Futbolcu defans in Futbolcu.manchesterCity)
            {
                Button btn = new Button();
                switch (defans.Ad)
                {
                    case "Kevin":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(331, 236);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Phil":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(458, 122);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Jack":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(458, 339);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                }
            }
        }
        void UcluForvet()
        {
            foreach (Futbolcu defans in Futbolcu.manchesterCity)
            {
                Button btn = new Button();
                switch (defans.Ad)
                {
                    case "Raheem":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(631, 60);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Riyad":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(663, 236);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                    case "Gabriel":
                        btn.Top = 55;
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Location = new Point(631, 409);
                        btn.Text = defans.FormaNumarasi;
                        btn.Name = defans.Ad + " " + defans.Soyad;
                        this.Controls.Add(btn);
                        btn.Click += Btn_Click;
                        break;
                }
            }
        }
        
        private void FootballAreaForm_Load(object sender, EventArgs e)
        {
            Kaleci k1 = new Kaleci("Ederson", "", "31");
            Defans d1 = new Defans("Kyle", "Walker", "2");
            Defans d2 = new Defans("Ruben", "Dias", "3");
            Defans d3 = new Defans("John", "Stones", "5");
            Defans d4 = new Defans("Benjamin", "Mendy", "2");
            OrtaSaha o1 = new OrtaSaha("Kevin", "De Bruyne", "17");
            OrtaSaha o2 = new OrtaSaha("Phil", "Foden", "47");
            OrtaSaha o3 = new OrtaSaha("Jack", "Grealish", "10");
            Forvet f1 = new Forvet("Gabriel", "Jesus", "9");
            Forvet f2 = new Forvet("Riyad", "Mahrez", "26");
            Forvet f3 = new Forvet("Raheem", "Sterling", "7");
           Futbolcu.manchesterCity = new List<Futbolcu>() { k1,d1, d2, d3,d4,o1, o2 ,o3,f1, f2, f3 };
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Temizle();
                    Kaleci();
                    UcluDef();
                    BesliOrtasaha();
                    IkiliForvet();
                    break;
                case 1:
                    Temizle();
                    Kaleci();
                    DortluDef();
                    UcluOrtaSaha();
                    UcluForvet();
                    break;
                case 2:
                    Temizle();
                    Kaleci();
                    UcluDef();
                    DortluOrtaSaha();
                    UcluForvet();
                    break;
                case 3:
                    Temizle();
                    Kaleci();
                    DortluDef();
                    DortluOrtaSaha();
                    IkiliForvet();
                    break;
            }
        }
    }
}
