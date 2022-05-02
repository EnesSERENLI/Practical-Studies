using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevu
{
    public class Brans
    {
        public Brans(string ad)
        {
            BransAd = ad;
        }
        public string BransAd { get; set; }
        public List<Brans> branslar = new List<Brans>();
        public override string ToString()
        {
            return $"{BransAd}";
        }
    }
}
