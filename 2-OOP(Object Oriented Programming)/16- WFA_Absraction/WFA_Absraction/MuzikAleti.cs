using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Absraction
{
    public abstract class MuzikAleti //Bu sınıfın görevi sadece kalıtım vermek. Bununla instance alınamayacak. 
    {
        /*
        - Abstract olarak tanımlanan bir class'tan instance alınamaz.
        - Abstract metotlar sadece abstract class'lar içerisinde kullanılır.
        - Abstract metotlar virtual olarak tanımlanmazlar. Mecburi ezilmeleri gerekiyor.
        - Abstract class'lar static olarak tanımlanamazlar.
        - Abstract metotların gövdesi olamaz. scope'ları olmaz.
         */
        public string Tur { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }

        public abstract string Cal(); //Müzikaleti ses çıkarır bu zorunlu birşey. virtual yazıp ezebiliriz. Ancak ezmezsek öyle kalmış olur. Ancak abstract yaparsak mecbur ezmek zorunda kalırız. Abstaract metot'ların scope'u olmaz.

    }
}
