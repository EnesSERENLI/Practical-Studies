using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Interface
{
    public class Audi : Araba
    {
        public override string MaxHiz()
        {
            return Model + " 320km/h hız yapmaktadır.";
        }
    }
}
