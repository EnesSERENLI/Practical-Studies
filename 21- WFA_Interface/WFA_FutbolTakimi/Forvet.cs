using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_FutbolTakimi
{
    public class Forvet : Futbolcu,IFutbolcu
    {
        public Forvet()
        {

        }
        public Forvet(string ad, string soyad, string formaNo)
        {
            Ad = ad;
            Soyad = soyad;
            FormaNumarasi = formaNo;
        }
        public override int SutGuc
        {
            get ; set;
        }

        public string CalimAt()
        {
            return Ad + " çalım attı";
        }

        public string Kos()
        {
            return Ad + " koşuyor...";
        }

        public string PressYap()
        {
            return Ad + " press yapıyor...";
        }

      

        public string SutCek()
        {
            return SutGuc.ToString();
        }

        public string TopKurtar()
        {
            return Ad + " topu kurtardı.";
        }

        public override string ToString()
        {
            return Ad + " " + Soyad + " " + FormaNumarasi;
        }
    }
}
