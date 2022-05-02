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
    public class Priest : IAlliance, IHorde, ISkill
    {
        public Priest()
        {
            GenerateHumanAccount = new PriestAccount();
            GenerateNightElfAccount = new PriestAccount();
            GenerateDwarfAccount = new PriestAccount();
            GenerateUndeadAccount = new PriestAccount();
            GenerateBloodElfAccount = new PriestAccount();
            GenerateOrcAccount = new PriestAccount();
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
            return $"Priest: {Name} {Damage} şiddetinde saldırdı";
        }

        public string Defence()
        {
            return $"Priest: {Name} {Block} değerinde hasar engelledi";
        }
    }
}
