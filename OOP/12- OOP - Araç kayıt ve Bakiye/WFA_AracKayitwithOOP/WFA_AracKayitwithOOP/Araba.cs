using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AracKayitwithOOP
{
    internal class Araba
    {
        //Encapsulation
        private int _yil;
        public int Yil
        {
            get
            {
                return _yil;
            }
            set
            {
                if (value <= 2022 && value >= 2015)
                {
                    _yil = value;
                }
            }
        }

        //fields
        public string Marka;

        public string model;
        public string yakitTipi;
        public string vitesTipi;
        public int renk;


    }
}
