using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Interface
{
    public abstract class Araba
    {
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }



        public abstract string MaxHiz();
        
    }
}
