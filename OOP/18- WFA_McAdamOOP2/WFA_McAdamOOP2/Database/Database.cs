using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdamOOP2.Database
{
    public static class Database
    {
        public static List<decimal> ciroListesi = new List<decimal>();
        public static List<decimal> extraGelirListesi = new List<decimal>();
        public static List<decimal> toplamSiparisListesi = new List<decimal>();
        public static List<decimal> SatilanUrunAdetListesi = new List<decimal>();
        public static List<string> siparislerListesi = new List<string>();

        public static decimal SatilanUrunAdetHesapla()
        {
            decimal satilanAdet = 0;
            foreach (decimal sAdet in Database.SatilanUrunAdetListesi)
            {
                satilanAdet += sAdet;
            }
            return satilanAdet;
        }
        public static decimal ToplamSiparisAdetHesapla()
        {
            decimal toplamSiparis = 0;
            foreach (decimal tSipatis in Database.toplamSiparisListesi)
            {
                toplamSiparis += tSipatis;
            }
            return toplamSiparis;
        }
        public static decimal ExtraHesapla()
        {
            decimal toplamExtra = 0;
            foreach (decimal ex in Database.extraGelirListesi)
            {
                toplamExtra += ex;
            }
            return toplamExtra;
        }
        public static decimal CiroHesapla()
        {
            decimal toplamCiro = 0;
            foreach (decimal c in Database.ciroListesi)
            {
                toplamCiro += c;
            }
            return toplamCiro;
        }

    }
}
