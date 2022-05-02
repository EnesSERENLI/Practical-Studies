using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Giyim
    {
        public virtual string Kategori { get { return "Kıyafet"; } }
        public decimal Fiyat { get; set; }
        public decimal KdvFiyat { get { return Fiyat * 1.18m; } }
        public string Beden { get; set; }
        public string Renk { get; set; }
        public string Marka { get; set; }
    }
}
