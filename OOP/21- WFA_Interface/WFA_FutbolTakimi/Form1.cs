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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Futbolcu> liverpol = new List<Futbolcu>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Kaleci kaleci = new Kaleci();
            kaleci.Soyad = "Buffon";

            Defans defans = new Defans();
            defans.Ad = "Van";
            defans.Soyad = "Dijk";
            defans.FormaNumarasi = "2";

            OrtaSaha ortaSaha = new OrtaSaha();
            ortaSaha.Ad = "Steven";
            ortaSaha.Soyad = "Gerrard";
            ortaSaha.FormaNumarasi = "8";

            Forvet forvet = new Forvet();
            forvet.Ad = "Zlatan";
            forvet.Soyad = "İbrahimovic";
            forvet.FormaNumarasi = "10";

            liverpol.Add(kaleci);
            liverpol.Add(defans);
            liverpol.Add(ortaSaha);
            liverpol.Add(forvet);

            foreach (Futbolcu futbolcu in liverpol)
            {
                listBox1.Items.Add(futbolcu);
            }

           string result= forvet.CalimAt();
            MessageBox.Show(result);

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                Futbolcu seciliFutbolcu = (Futbolcu)listBox1.SelectedItems[0];
                MessageBox.Show(seciliFutbolcu.Ad + " " + seciliFutbolcu.Soyad + " " + seciliFutbolcu.FormaNumarasi);
            }
        }
    }
}
