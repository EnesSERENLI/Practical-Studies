using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Interface
{
    public interface IYetenek //yetenek kazandırmak için interface tanımlandı.

    {

        //Interface içerisinde tanımlanan property veya metotların erişim belirteçleri olamaz!
        /*
            Interfaceler, class gibi türler için oluşturulmuş modellerdir. Bir sınıfın temelde hangi üyelerden oluşacağını berlirleyen şablon yapılardır. Bu satede oluşturulaacak sınıflara öncülük ederler. içerisinde tanımlanan property veya metotlar kullanılması zorunlıdır.

        -- Sınıflara yetenek kazandırırlar.
        -- Interface olarak tanımlanan class'dan instance 
         */
       string OtoPilot();
       
    }
}
