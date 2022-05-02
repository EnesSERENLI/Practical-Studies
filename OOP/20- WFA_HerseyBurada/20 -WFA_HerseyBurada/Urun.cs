using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20__WFA_HerseyBurada
{
    public abstract class Urun
    {
        public decimal Fiyat { get; set; }
        private decimal _kdvFiyat;
        public decimal Adet { get; set; }

        public decimal KDVFiyat
        {
            get 
            {  
                _kdvFiyat = ToplamTutar*1.18m;
                return _kdvFiyat;
            }
            
        }
        public decimal ToplamTutar { get; set; }
    }
}
