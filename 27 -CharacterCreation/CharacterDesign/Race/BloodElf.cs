using CharacterDesign.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign.Race
{
    public class BloodElf:IHorde
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public short Level { get; set; }
        public double Damage { get; set; }
        public double Block { get; set; }
        public IOrcAccount GenerateOrcAccount { get; set; }
        public IBloodElfAccount GenerateBloodElfAccount { get; set; }
        public IUndeadAccount GenerateUndeadAccount { get; set; }
        public bool IsWarrior { get; set; }
        public bool IsMage { get; set; }
        public bool IsPriest { get; set; }
        public bool IsHunter { get; set; }
    }
}
