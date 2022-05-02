using CharacterDesign.Abstract;
using CharacterDesign.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign.Generate
{
    public class HunterAccount : IHumanAccount, INightElfAccount, IDwarfAccount, IOrcAccount, IBloodElfAccount, IUndeadAccount
    {
        public Dwarf CreateCharacte(IAlliance alliance)
        {
            Dwarf dwarf = new Dwarf();
            dwarf.ID = alliance.ID;
            dwarf.Name = alliance.Name;
            dwarf.Level = alliance.Level;
            dwarf.Damage = alliance.Damage;
            dwarf.IsHunter = true;
            return dwarf;
        }

        public Human CreateCharacter(IAlliance alliance)
        {
            Human human = new Human();
            human.ID = alliance.ID;
            human.Name = alliance.Name;
            human.Level = alliance.Level;
            human.Damage = alliance.Damage;
            human.IsHunter = true;
            return human;
        }
        NightElf INightElfAccount.CreateCharacter(IAlliance alliance)
        {
            NightElf nightElf = new NightElf();
            nightElf.ID = alliance.ID;
            nightElf.Name = alliance.Name;
            nightElf.Level = alliance.Level;
            nightElf.Damage = alliance.Damage;
            nightElf.IsHunter = true;
            return nightElf;
        }
        public Orc CreateCharacter(IHorde horde)
        {
            Orc orc = new Orc();
            orc.ID = horde.ID;
            orc.Name = horde.Name;
            orc.Level = horde.Level;
            orc.Damage = horde.Damage;
            orc.IsHunter = true;
            return orc;
        }

        BloodElf IBloodElfAccount.CreateCharacter(IHorde horde)
        {
            BloodElf bloodElf = new BloodElf();
            bloodElf.ID = horde.ID;
            bloodElf.Name = horde.Name;
            bloodElf.Level = horde.Level;
            bloodElf.Damage = horde.Damage;
            bloodElf.IsHunter = true;
            return bloodElf;
        }

        Undead IUndeadAccount.CreateCharacter(IHorde horde)
        {
            Undead undead = new Undead();
            undead.ID = horde.ID;
            undead.Name = horde.Name;
            undead.Level = horde.Level;
            undead.Damage = horde.Damage;
            undead.IsHunter = true;
            return undead;
        }
    }
}
