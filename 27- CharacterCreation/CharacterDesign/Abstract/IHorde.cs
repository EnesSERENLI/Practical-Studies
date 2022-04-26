using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign.Abstract
{
    public interface IHorde
    {
        int ID { get; set; }
        string Name { get; set; }
        short Level { get; set; }
        double Damage { get; set; }
        double Block { get; set; }
        IOrcAccount GenerateOrcAccount { get; set; }
        IBloodElfAccount GenerateBloodElfAccount { get; set; }
        IUndeadAccount GenerateUndeadAccount { get; set; }
    }
}
