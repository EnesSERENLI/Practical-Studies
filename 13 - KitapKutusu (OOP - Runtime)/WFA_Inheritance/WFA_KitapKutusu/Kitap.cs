using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KitapKutusu
{
    public class Kitap:Urun
    {
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public Tur KitapTuru { get; set; }
        public string YayinEvi { get; set; }
        public string YazarAd { get; set; }

    }


    public class Tur
    {

    }
}
