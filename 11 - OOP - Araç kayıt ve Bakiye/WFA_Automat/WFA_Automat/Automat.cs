using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Automat
{
    internal class Automat
    {



        //Fields..

        public int bakiye;

        //Encapsulation --Property
        private int _alisveris;
     
        public int Alisveris
        {
            get { return _alisveris; }
            set
            {
                if (value <= bakiye)
                {
                    _alisveris = value;
                }
                else
                {
                    value = 0;
                    _alisveris = value;
                }
            }
        }
        
        private int _paraCek;
        public int ParaCek
        {
            get { return _paraCek; }
            set
            {
                if (value <= bakiye)
                {
                    if (value > 0)
                    {
                        _paraCek = value;
                    }
                    else
                    {
                        value = 0;
                        _paraCek = value;
                    }
                }
                else
                {
                    value = 0;
                    _paraCek = value;

                }
            }
        }

        private int _paraYatir;
        public int ParaYatir
        {
            get { return _paraYatir; }
            set
            {
                if (value >= 1)
                {
                    _paraYatir = value;
                }
                else
                {
                    value = 0;
                    _paraYatir = value;
                }
            }
        }
    }
}
