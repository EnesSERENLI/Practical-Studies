using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Doktor
    {
        //public Doktor(string doktor , Brans brans)
        //{
        //    DoktorAd = doktor;
        //    DoktorBrans = brans;
        //}
        public string DoktorAd { get; set; }
        public Brans DoktorBrans { get; set; }
        public override string ToString()
        {
            return DoktorAd;
        }
        public static List<Doktor> doktorlarListesi = new List<Doktor>();
    }
}
