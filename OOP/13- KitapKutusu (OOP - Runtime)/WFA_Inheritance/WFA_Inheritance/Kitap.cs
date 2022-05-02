using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance
{
    public class Kitap:Urun
    {
        //Bir kitabın ...'sı olur

        public string YazarAd { get; set; }

        public string YayinEvi { get; set; }

        public string KitapAd { get; set; }

        
    }
}
