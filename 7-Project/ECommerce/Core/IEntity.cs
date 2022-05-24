using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IEntity<T> //Her tabloda ID'yi T tipine göre ver ilerde integer yapmak istersek yada Guid bu şekilde istedğimiz zaman tüm tablolarda değiştirebiliriz..
    {
        T ID { get; set; }
    }
}
