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
    public class Warrior : IAlliance, IHorde, ISkill
    {
        public Warrior()
        {
            GenerateHumanAccount = new WarriorAccount();
            GenerateNightElfAccount = new WarriorAccount();
            GenerateDwarfAccount = new WarriorAccount();
            GenerateBloodElfAccount = new WarriorAccount();
            GenerateOrcAccount = new WarriorAccount();
            GenerateUndeadAccount = new WarriorAccount();
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
            return $"Warrior: {Name} {Damage} şiddetinde kılıçla saldırdı";
        }

        public string Defence()
        {
            return $"Warrior: {Name} {Block} değerinde hasar engelledi";
        }
    }
}
