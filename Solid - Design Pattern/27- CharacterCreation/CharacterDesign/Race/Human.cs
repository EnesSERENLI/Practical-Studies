using CharacterDesign.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign.Race
{
    public class Human:IAlliance
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public short Level { get; set; }
        public double Damage { get; set; }
        public double Block { get; set; }
        public IHumanAccount GenerateHumanAccount { get; set; }
        public INightElfAccount GenerateNightElfAccount { get; set; }
        public IDwarfAccount GenerateDwarfAccount { get; set; }
        public bool IsWarrior { get; set; }
        public bool IsMage { get; set; }
        public bool IsPriest { get; set; }
        public bool IsHunter { get; set; }
    }
}
