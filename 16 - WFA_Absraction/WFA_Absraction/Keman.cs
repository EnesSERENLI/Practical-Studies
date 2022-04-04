using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Absraction
{
    public class Keman : MuzikAleti
    {
        public override string Cal()
        {
            return "keman çalınıyor..";
        }
        public override string ToString()
        {
            return "Keman "+Marka;
        }
    }
}
