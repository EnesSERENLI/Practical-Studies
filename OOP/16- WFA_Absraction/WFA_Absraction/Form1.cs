using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Absraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<MuzikAleti> muzikAletleri = new List<MuzikAleti>();
        List<Muzisyen> muzisyenler = new List<Muzisyen>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //MuzikAleti muzikAleti = new MuzikAleti(); //İnstance alınamıyor. Diğer class'lara kalıtım vericek sadece.
            //Klasik Gitar
            KlasikGitar klasikGitar = new KlasikGitar();
            klasikGitar.Marka = "ABC";
            klasikGitar.Model = "XYZ";
            klasikGitar.Tur = "Telli";
            klasikGitar.Fiyat = 5000;
            muzikAletleri.Add(klasikGitar);
            //Keman
            Keman keman = new Keman();
            keman.Marka = "TTT";
            keman.Model = "ttt";
            keman.Tur = "Telli";
            keman.Fiyat = 10000;
            muzikAletleri.Add(keman);
            //Piyano
            Piyano piyano = new Piyano();
            piyano.Marka = "Steinway";
            piyano.Model = "kafabinbeşyüz";
            piyano.Tur = "Tuşlu";
            piyano.Fiyat = 25000;
            muzikAletleri.Add(piyano);
            //Muzisyen 1
            Muzisyen muzisyen1= new Muzisyen();
            muzisyen1.Ad = "Sıla";
            muzisyen1.CaldigiEnstruman = klasikGitar;
            muzisyenler.Add(muzisyen1);
            //Muzisyen 2
            Muzisyen muzisyen2 = new Muzisyen();
            muzisyen2.Ad = "Caner";
            muzisyen2.CaldigiEnstruman = piyano;
            muzisyenler.Add(muzisyen2);
            //Muzisyen 3
            Muzisyen muzisyen3 = new Muzisyen();
            muzisyen3.Ad = "Tuba";
            muzisyen3.CaldigiEnstruman = keman;
            muzisyenler.Add(muzisyen3);

            MessageBox.Show(muzisyen1.CaldigiEnstruman.Cal());
            MessageBox.Show(muzisyen2.CaldigiEnstruman.Cal());
            MessageBox.Show(muzisyen3.CaldigiEnstruman.Cal());

            lstMuzisyenler.DataSource = muzisyenler.ToList();
            //foreach (Muzisyen mz in muzisyenler)
            //{
            //    lstMuzisyenler.Items.Add(mz);
            //}
            foreach (MuzikAleti mzAleti in muzikAletleri)
            {
                if (mzAleti is Keman)
                {
                    Keman km = (Keman)mzAleti;
                    lstKeman.Items.Add(km);
                }
                if (mzAleti is Piyano)
                {
                    Piyano piy = (Piyano)mzAleti;
                    lstPiyano.Items.Add(piy);
                }
                if (mzAleti is KlasikGitar)
                {
                    KlasikGitar kg = (KlasikGitar)mzAleti;
                    lstKlasikGitar.Items.Add(kg);
                }
            }
        }
    }
}
