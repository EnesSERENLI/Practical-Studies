using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20__WFA_HerseyBurada
{
    public class Giyim:Urun,IUrun,IUrunYonetimi
    {
        public Giyim()
        {

        }
        public Giyim(string kategori,string marka,decimal fiyat)
        {
            Kategori = kategori;
            Marka = marka;
            Fiyat = fiyat;
        }
        public string Kategori { get; set; }
        public string Marka { get; set; }
        public KumasTipi KumasTipi { get; set; }
        public Beden Beden { get; set; }
        public Color Renk { get; set; }

        public static List<Giyim> erkekGiyimListesi = new List<Giyim>() { new Giyim("Tişört", "Mavi", 30), new Giyim("Tişört", "Koton", 20), new Giyim("Tişört", "Nike", 70), new Giyim("Gömlek", "AltınYıldız", 120), new Giyim("Gömlek", "Mavi", 100), new Giyim("Gömlek", "Pierre Cardin", 150), new Giyim("Gömlek", "US Polo Assn", 105), new Giyim("Pantolon", "Colin's", 110), new Giyim("Pantolon", "LC Waikiki", 70), new Giyim("Pantolon", "Hummel", 100), new Giyim("Mont", "Avva", 400), new Giyim("Mont", "LTB", 350), new Giyim("Mont", "Adidas", 750), new Giyim("Kazak", "Kiğılı", 250), new Giyim("Kazak", "Loft", 125), new Giyim("Kazak", "Süvari", 200) };

        public static List<Giyim> kadinGiyimListesi = new List<Giyim>() { new Giyim("Elbise", "Mango", 120), new Giyim("Elbise", "Eyyo", 150), new Giyim("Elbise", "Lafaba", 100), new Giyim("Elbise", "Armine", 250), new Giyim("Bluz", "Erliva", 88), new Giyim("Bluz", "Olalook", 140), new Giyim("Bluz", "Stealla Pulvis", 105), new Giyim("Pantolon", "Big Love", 170), new Giyim("Pantolon", "SHEISMONO", 165), new Giyim("Pantolon", "Dilvin", 234), new Giyim("Etek", "Soyo", 138), new Giyim("Etek", "Fulvia", 212), new Giyim("Etek", "Societa", 125), new Giyim("Mont", "Rouge", 3000), new Giyim("Mont", "Barbour", 4500), new Giyim("Mont", "Network", 7000) };
        public override string ToString()
        {
            return Marka;
        }

        //Methods
        public decimal TutarHesapla(object obj)
        {
            Giyim giyim = (Giyim)obj;
            ToplamTutar = giyim.Fiyat * giyim.Adet;
            return ToplamTutar;
        }
        public ListViewItem SepeteEkle(object obj)
        {
            Giyim giyim = (Giyim)obj;
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = giyim.Kategori;
            lvi.SubItems.Add(giyim.Marka);
            lvi.SubItems.Add(giyim.Beden.ToString());
            lvi.SubItems.Add(giyim.KumasTipi.ToString());
            lvi.SubItems.Add("");
            lvi.SubItems[4].BackColor = giyim.Renk;
            lvi.SubItems.Add(giyim.Adet.ToString());
            lvi.SubItems.Add(giyim.TutarHesapla(giyim).ToString("C2"));
            lvi.SubItems.Add(giyim.KDVFiyat.ToString("C2"));
            return lvi;
        }

        public void UrunEkle(string kategori, string marka, decimal fiyat)
        {
            Giyim erkekGiyim = new Giyim();
            erkekGiyim.Kategori = kategori;
            erkekGiyim.Marka = marka;
            erkekGiyim.Fiyat = fiyat;
            Giyim.erkekGiyimListesi.Add(erkekGiyim);
        }
        public void UrunEkle(decimal fiyat, string kategori, string marka)
        {
            Giyim kadinGiyim = new Giyim();
            kadinGiyim.Kategori = kategori;
            kadinGiyim.Marka = marka;
            kadinGiyim.Fiyat = fiyat;
            Giyim.kadinGiyimListesi.Add(kadinGiyim);
        }

        public void UrunSil(string kategori, string marka)
        {
            foreach (Giyim erkek in Giyim.erkekGiyimListesi)
            {
                if (erkek.Kategori == kategori && erkek.Marka == marka)
                {
                    Giyim.erkekGiyimListesi.Remove(erkek);
                    break;
                }
            }
            foreach (Giyim kadin in Giyim.kadinGiyimListesi)
            {
                if (kadin.Kategori == kategori && kadin.Marka == marka)
                {
                    Giyim.kadinGiyimListesi.Remove(kadin);
                    break;
                }
            }
        }

        public void UrunGuncelle(string eskiKategori, string eskiMarka, string yeniKategori, string yeniMarka, decimal fiyat)
        {
            foreach (Giyim erkek in Giyim.erkekGiyimListesi)
            {
                if (erkek.Kategori == eskiKategori && erkek.Marka == eskiMarka)
                {
                    erkek.Kategori = yeniKategori;
                    erkek.Marka = yeniMarka;
                    erkek.Fiyat = fiyat;
                }
            }
            foreach (Giyim kadin in Giyim.kadinGiyimListesi)
            {
                if (kadin.Kategori == eskiKategori && kadin.Marka == eskiMarka)
                {
                    kadin.Kategori = yeniKategori;
                    kadin.Marka = yeniMarka;
                    kadin.Fiyat = fiyat;
                }
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------
    public enum Beden
    {
        XS,S,M,L,XL,XXXL
    }
    //----------------------------------------------------------------------------------------------------------
    public enum KumasTipi
    {
        Dokuma,Örme,Triko,Pamuk,OrganikPamuk,Denim
    }
}
