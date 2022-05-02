using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20__WFA_HerseyBurada
{
    public class Computer : Urun,IUrun,IUrunYonetimi
    {
        public Computer()
        {

        }
        public Computer(string marka, string model, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public RAM RAM { get; set; }
        public EkranKarti EkranKarti { get; set; }

        public static List<Computer> computerList = new List<Computer>() { new Computer("Monster","Abra",14000), new Computer("Monster", "Tulpar", 20000), new Computer("Monster", "Semruk", 50000), new Computer("MSI", "Modern", 11000), new Computer("MSI", "Bravo", 14500), new Computer("MSI", "Katana", 26000), new Computer("Asus", "Vivobook", 20000), new Computer("Asus", "TUF", 14000), new Computer("Asus", "ROG Zephyrus", 19200), };

        public override string ToString()
        {
            return Model;
        }

        //Methods
        public ListViewItem SepeteEkle(object obj)
        {
            Computer bilgisayar = (Computer)obj;
            ListViewItem lvi = new ListViewItem();
            lvi.Text = bilgisayar.Marka;
            lvi.SubItems.Add(bilgisayar.Model);
            lvi.SubItems.Add(bilgisayar.RAM.ToString());
            lvi.SubItems.Add(bilgisayar.EkranKarti.ToString());
            lvi.SubItems.Add(bilgisayar.Adet.ToString());
            lvi.SubItems.Add(bilgisayar.TutarHesapla(bilgisayar).ToString("C2"));
            lvi.SubItems.Add(bilgisayar.KDVFiyat.ToString("C2"));
            return lvi;
        }

        public decimal TutarHesapla(object obj)
        {
            Computer bilgisayar = (Computer)obj;
            bilgisayar.ToplamTutar = bilgisayar.Adet * (bilgisayar.Fiyat + bilgisayar.RAM.Fiyat + bilgisayar.EkranKarti.Fiyat);
            return bilgisayar.ToplamTutar;
        }

        public void UrunEkle(string marka, string model, decimal fiyat)
        {
            Computer pc = new Computer();
            pc.Marka = marka;
            pc.Model = model;
            pc.Fiyat = fiyat;
            Computer.computerList.Add(pc);
        }

        public void UrunSil(string marka, string model)
        {
            foreach (Computer pc in Computer.computerList)
            {
                if (pc.Marka == marka && pc.Model == model)
                {
                    Computer.computerList.Remove(pc);
                    break;
                }
            }
        }

        public void UrunGuncelle(string eskiMarka, string eskiModel, string yeniMarka, string yeniModel, decimal fiyat)
        {
            foreach (Computer pc in Computer.computerList)
            {
                if (pc.Marka == eskiMarka && pc.Model == eskiModel)
                {
                    pc.Marka = yeniMarka;
                    pc.Model = yeniModel;
                    pc.Fiyat = fiyat;
                }
            }
        }
    }
    //-------------------------------------------------------------------------------------------------------
    public class EkranKarti:Urun
    {
        public EkranKarti(string marka,decimal fiyat)
        {
            Marka=marka;
            Fiyat=fiyat;    
        }
        public string Marka { get; set; }

        public static List<EkranKarti> ekranKartiListesi = new List<EkranKarti>() { new EkranKarti("GForce RTX 3060", 12000), new EkranKarti("GForce RTX 3060 Ti", 12500), new EkranKarti("GForce RTX 3080", 15000), new EkranKarti("GForce RTX 3080 Ti", 15000) };
        public override string ToString()
        {
            return Marka;
        }
    }
}
