using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20__WFA_HerseyBurada
{
    public class Telefon : Urun, IUrun, IUrunYonetimi
    {
        public Telefon()
        {

        }
        public Telefon(string marka, string model, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public RAM RAM { get; set; }
        public HafizaKarti Hafiza { get; set; }

        public static List<Telefon> telefonListesi = new List<Telefon>()
        {
            new Telefon("Apple","Iphone 11",11000),
            new Telefon("Apple","Iphone 12",15000),
            new Telefon("Apple","Iphone 13 Pro",30000),
            new Telefon("Xiaomi","Red mi Note 10 S",4500),
            new Telefon("Xiaomi","Red mi Note 11 Pro",7000),
            new Telefon("Xiaomi","Red mi Note 11 Lite",5500),
            new Telefon("Samsung","Galaxy M22",4000),
            new Telefon("Samsung","Galaxy A52",5800),
            new Telefon("Samsung","Galaxy S22 Ultra",24000)
        };
        public override string ToString()
        {
            return Model;
        }

        //Methods
        public ListViewItem SepeteEkle(object obj)
        {
            Telefon telefon = (Telefon)obj;
            ListViewItem lvi = new ListViewItem();
            lvi.Text = telefon.Marka;
            lvi.SubItems.Add(telefon.Model);
            lvi.SubItems.Add(telefon.RAM.ToString());
            lvi.SubItems.Add(telefon.Hafiza.ToString());
            lvi.SubItems.Add(telefon.Adet.ToString());
            lvi.SubItems.Add(telefon.TutarHesapla(telefon).ToString("C2"));
            lvi.SubItems.Add(telefon.KDVFiyat.ToString("C2"));
            return lvi;
        }

        public decimal TutarHesapla(object obj)
        {
            Telefon telefon = (Telefon)obj;
            telefon.ToplamTutar = telefon.Adet * (telefon.Fiyat + telefon.RAM.Fiyat + telefon.Hafiza.Fiyat);
            return telefon.ToplamTutar;
        }


        public void UrunSil(string marka, string model)
        {
            foreach (Telefon tel in Telefon.telefonListesi)
            {
                if (tel.Marka == marka && tel.Model == model)
                {
                    Telefon.telefonListesi.Remove(tel);
                    break;
                }
            }
        }

        public void UrunGuncelle(string eskiMarka, string eskiModel, string yeniMarka, string yeniModel, decimal fiyat)
        {
            foreach (Telefon tel in Telefon.telefonListesi)
            {
                if (tel.Marka == eskiMarka && tel.Model == eskiModel)
                {
                    tel.Marka = yeniMarka;
                    tel.Model = yeniModel;
                    tel.Fiyat = fiyat;
                }
            }
        }

        public void UrunEkle(string marka, string model, decimal fiyat)
        {
            Telefon tel = new Telefon();
            tel.Marka = marka;
            tel.Model = model;
            tel.Fiyat = fiyat;
            Telefon.telefonListesi.Add(tel);
        }
    }
}
