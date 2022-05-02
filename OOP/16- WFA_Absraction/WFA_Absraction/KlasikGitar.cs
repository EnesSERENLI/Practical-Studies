using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Absraction
{
    public class KlasikGitar:Gitar
    {
        public override string Cal()
        {
            return "Klasik gitar çalınıyor...";
        }
        public override string ToString()
        {
            return "Klasik Gitar " + Marka;
        }
    }
}
