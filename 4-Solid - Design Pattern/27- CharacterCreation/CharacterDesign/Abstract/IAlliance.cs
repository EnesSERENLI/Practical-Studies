using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign.Abstract
{
    public interface IAlliance
    {
        int ID { get; set; }
        string Name { get; set; }
        short Level { get; set; }
        double Damage { get; set; }
        double Block { get; set; }
        IHumanAccount GenerateHumanAccount { get; set; }
        INightElfAccount GenerateNightElfAccount { get; set; }
        IDwarfAccount GenerateDwarfAccount { get; set; }
    }
}
