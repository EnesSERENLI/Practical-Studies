using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Randevu
    {
        public Randevu(string ad,string soyad, string tckn, Doktor dr, string br, DateTime dateTime)
        {
            HastaAd = ad;
            HastaSoyad = soyad;
            Tckn = tckn;
            DoktorAdi = dr;
            Brans = br;
            RandevuTarihi = dateTime;
            RandevuAlimTarihi = DateTime.Now;
        }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }
        public string Tckn { get; set; }
        public Doktor DoktorAdi { get; set; }
        public string Brans { get; set; } //bunu string yapmamız sebebi 
        public DateTime RandevuTarihi { get; set; }
        public DateTime RandevuAlimTarihi { get; set; }
        public static List<Randevu> randevuListesi = new List<Randevu>();
        public override string ToString()
        {
            return "Hasta Adı: "+HastaAd + " Hasta Soyadı: " + HastaSoyad + " Tckn: " + Tckn + " Doktor Adı: " + DoktorAdi + " Branş: " + Brans + " Randuvu Alım Tarihi " + RandevuAlimTarihi+" Randevu Alınan Tarih: "+RandevuTarihi;
        }
    }
}
