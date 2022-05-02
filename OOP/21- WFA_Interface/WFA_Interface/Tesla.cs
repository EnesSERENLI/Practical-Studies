using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Interface
{
    public class Tesla : Araba,IYetenek
    {
        public override string MaxHiz()
        {
            return Model + " 220km/h hız yapmaktadır.";
        }

       

        public string OtoPilot()
        {
            return Model + " otopilot aktif";
        }
    }
}
