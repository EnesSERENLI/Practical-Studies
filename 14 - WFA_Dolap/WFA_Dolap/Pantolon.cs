using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Pantolon:Giyim
    {
        public override string Kategori { get { return "Pantolon"; } }
        public string PacaTipi { get; set; }
        public string Desen { get; set; }

        public override string ToString()
        {
            return $"{Marka} - {Desen} - {Renk} - {PacaTipi} - {Fiyat.ToString("C2")}";
        }
    }
}
