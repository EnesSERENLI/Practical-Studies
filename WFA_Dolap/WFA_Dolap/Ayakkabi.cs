using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Ayakkabi:Giyim
    {
        public override string Kategori { get { return "Ayakkabı"; } }
        public int Numara { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"{Marka} - {Model} - {Renk} - {Numara} - {Fiyat.ToString("C2")}";
        }
    }
}
