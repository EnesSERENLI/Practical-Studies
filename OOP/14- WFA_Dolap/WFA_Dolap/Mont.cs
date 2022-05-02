using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Mont:Giyim
    {

        public override string Kategori { get { return "Mont"; } }
        public override string ToString()
        {
            return $"{Marka} - {Beden} - {Renk} - {Fiyat.ToString("C2")}";
        }
    }
}
