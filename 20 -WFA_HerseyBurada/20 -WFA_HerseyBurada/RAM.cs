using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20__WFA_HerseyBurada
{
    public class RAM:Urun
    {
        public RAM(string kapasite,decimal fiyat)
        {
            Kapasite = kapasite;
            Fiyat = fiyat;
        }
        public string Kapasite { get; set; }
        
        public static List<RAM> ramListesi = new List<RAM>() {new RAM("4 GB",500), new RAM("6 GB", 1000), new RAM("8 GB", 2000), };
        public override string ToString()
        {
            return Kapasite;
        }
    }
}
