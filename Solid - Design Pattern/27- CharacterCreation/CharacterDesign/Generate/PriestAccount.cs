using CharacterDesign.Abstract;
using CharacterDesign.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign.Generate
{
    public class PriestAccount : IHumanAccount, INightElfAccount, IDwarfAccount, IOrcAccount, IBloodElfAccount, IUndeadAccount
    {
        public Dwarf CreateCharacte(IAlliance alliance)
        {
            Dwarf dwarf = new Dwarf();
            dwarf.ID = alliance.ID;
            dwarf.Name = alliance.Name;
            dwarf.Level = alliance.Level;
            dwarf.Damage = alliance.Damage;
            dwarf.IsPriest = true;
            return dwarf;
        }

        public Human CreateCharacter(IAlliance alliance)
        {
            Human human = new Human();
            human.ID = alliance.ID;
            human.Name = alliance.Name;
            human.Level = alliance.Level;
            human.Damage = alliance.Damage;
            human.IsPriest = true;
            return human;
        }
        NightElf INightElfAccount.CreateCharacter(IAlliance alliance)
        {
            NightElf nightElf = new NightElf();
            nightElf.ID = alliance.ID;
            nightElf.Name = alliance.Name;
            nightElf.Level = alliance.Level;
            nightElf.Damage = alliance.Damage;
            nightElf.IsPriest = true;
            return nightElf;
        }
        public Undead CreateCharacter(IHorde horde)
        {
            Undead undead = new Undead();
            undead.ID = horde.ID;
            undead.Name = horde.Name;
            undead.Level = horde.Level;
            undead.Damage = horde.Damage;
            undead.IsPriest = true;
            return undead;
        }
        BloodElf IBloodElfAccount.CreateCharacter(IHorde horde)
        {
            BloodElf bloodElf = new BloodElf();
            bloodElf.ID = horde.ID;
            bloodElf.Name = horde.Name;
            bloodElf.Level = horde.Level;
            bloodElf.Damage = horde.Damage;
            bloodElf.IsPriest = true;
            return bloodElf;
        }

        Orc IOrcAccount.CreateCharacter(IHorde horde)
        {
            Orc orc = new Orc();
            orc.ID = horde.ID;
            orc.Name = horde.Name;
            orc.Level = horde.Level;
            orc.Damage = horde.Damage;
            orc.IsPriest = true;
            return orc;
        }
    }
}
