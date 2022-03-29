using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class T_shirt:Giyim
    {
        public override string Kategori { get { return "T_shirt"; } }
        public string KumasTipi { get; set; }

        public override string ToString()
        {
            return $"{Marka} - {Beden} - {Renk} - {KumasTipi} - {Fiyat.ToString("C2")}";
        }
    }
}
