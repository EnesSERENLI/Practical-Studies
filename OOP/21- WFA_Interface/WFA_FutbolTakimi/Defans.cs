using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_FutbolTakimi
{
    public class Defans : Futbolcu,IFutbolcu
    {
        public Defans()
        {

        }
        public Defans(string ad, string soyad, string formaNo)
        {
            Ad = ad;
            Soyad = soyad;
            FormaNumarasi = formaNo;
        }
        public static List<Defans> defansListesi = new List<Defans>();
        public override int SutGuc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
