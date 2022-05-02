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
    public class Hunter : IAlliance, IHorde, ISkill
    {
        public Hunter()
        {
            GenerateHumanAccount = new HunterAccount();
            GenerateNightElfAccount = new HunterAccount();
            GenerateDwarfAccount = new HunterAccount();
            GenerateBloodElfAccount = new HunterAccount();
            GenerateOrcAccount = new HunterAccount();
            GenerateUndeadAccount = new HunterAccount();
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
            return $"Hunter: {Name} {Damage} şiddetinde ok attı";
        }

        public string Defence()
        {
            return $"Hunter: {Name} {Block} değerinde hasar engelledi";
        }
    }
}
