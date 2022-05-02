using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_FutbolTakimi
{
    public class Kaleci : Futbolcu,IFutbolcu
    {
        public Kaleci()
        {

        }
        public Kaleci(string ad, string soyad, string formaNo)
        {
            Ad = ad;
            Soyad = soyad;
            FormaNumarasi = formaNo;
        }
        private int _sutGucu;
     

        public override int SutGuc
        {
            get { return _sutGucu; }
            set
            {
                if (value > 70)
                {
                    MessageBox.Show("şut gücü 70'den büyük olduğu için isabet oranı düşer");
                }
            }
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
