using CharacterDesign.Abstract;
using CharacterDesign.CharSkills;
using CharacterDesign.Generate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign.Account
{
    public class Mage : IAlliance, IHorde, ISkill
    {
        public Mage()
        {
            GenerateHumanAccount = new MageAccount();
            GenerateNightElfAccount = new MageAccount();
            GenerateDwarfAccount = new MageAccount();
            GenerateBloodElfAccount = new MageAccount();
            GenerateOrcAccount = new MageAccount();
            GenerateUndeadAccount = new MageAccount();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public short Level { get; set; }
        public double Damage { get; set; }
        public double Block { get; set; }
        public IHumanAccount GenerateHumanAccount { get; set; }
        public INightElfAccount GenerateNightElfAccount { get; set; }
        public IDwarfAccount GenerateDwarfAccount { get; set; }
        public IOrcAccount GenerateOrcAccount { get; set; }
        public IBloodElfAccount GenerateBloodElfAccount { get; set; }
        public IUndeadAccount GenerateUndeadAccount { get; set; }

        public string Attack()
        {
            return $"Mage: {Name} {Damage} şiddetinde büyü yaptı";
        }

        public string Defence()
        {
            return $"Mage: {Name} {Block} değerinde hasar engelledi";
        }
    }
}
