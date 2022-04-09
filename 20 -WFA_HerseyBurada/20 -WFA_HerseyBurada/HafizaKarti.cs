using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20__WFA_HerseyBurada
{
    public class HafizaKarti:Urun
    {
        public HafizaKarti(string kart,decimal fiyat)
        {
            HafizaKart = kart;
            Fiyat = fiyat;
        }
        public string HafizaKart { get; set; }
        public static List<HafizaKarti> hafizaKartiListesi = new List<HafizaKarti>() { new HafizaKarti("32 GB", 750), new HafizaKarti("64 GB", 1250), new HafizaKarti("128 GB", 1800) };
        public override string ToString()
        {
            return HafizaKart;
        }
    }
}
