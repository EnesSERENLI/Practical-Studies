using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Absraction
{
    public class Muzisyen
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public MuzikAleti CaldigiEnstruman { get; set; }
        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
