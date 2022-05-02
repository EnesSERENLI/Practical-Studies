using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Absraction
{
    public class Piyano : MuzikAleti
    {
        public override string Cal()
        {
            return "piyano çalınıyor...";
        }
        public override string ToString()
        {
            return "Piyano " + Marka;
        }
    }
}
