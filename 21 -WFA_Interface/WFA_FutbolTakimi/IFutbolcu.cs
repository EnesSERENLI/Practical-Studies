using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_FutbolTakimi
{
    public interface IFutbolcu
    {
        //Kos
        string Kos();

        //CalimAt
        string CalimAt();

        //SutCek
        string SutCek();

        //PressYap
        string PressYap();

        //TopKurtar
        string TopKurtar();
    }
}
