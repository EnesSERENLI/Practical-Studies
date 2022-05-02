using CharacterDesign.Abstract;
using CharacterDesign.Account;
using CharacterDesign.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAlliance> characterList = new List<IAlliance>() { new Warrior { ID = 1, Name = "CreastFall", Level = 1, Damage = 10 } };
            List<Human> humanList = new List<Human>();

            List<IHorde> hordeList = new List<IHorde>() {
                new Priest { ID = 1, Name = "DoinB", Level = 1, Damage = 5 },
                new Warrior { ID = 2, Name = "Faker", Level = 1, Damage = 10 },
                new Hunter { ID = 3, Name = "HolyPhoenix", Level = 1, Block = 7 }
            };

            Hunter hunter = new Hunter();
            hunter.ID = 4;
            hunter.Name = "Doublelift";
            hunter.Damage = 9;
            hunter.Block = 8;

            Warrior warrior = new Warrior();
            warrior.ID = 4;
            warrior.Name = "Nuguri";
            warrior.Damage = 12;
            warrior.Block = 6;


            List<Orc> orcList = new List<Orc>();
            List<Undead> undeadList = new List<Undead>();
            orcList.Add(hunter.GenerateOrcAccount.CreateCharacter(hunter));

            Console.WriteLine(hunter.Attack());
            Console.WriteLine(hunter.Defence());
            Console.ReadLine();

            Console.WriteLine(warrior.Attack());
            Console.WriteLine(warrior.Defence());
            Console.ReadLine();
            foreach (IAlliance character in characterList)
            {
                humanList.Add(character.GenerateHumanAccount.CreateCharacter(character));//Alliance human oldu..
            }
            foreach (IHorde hordechar in hordeList)
            {
                if (hordechar.ID == 3)
                {
                    undeadList.Add(hordechar.GenerateUndeadAccount.CreateCharacter(hordechar));//undead
                }
                else
                {
                    orcList.Add(hordechar.GenerateOrcAccount.CreateCharacter(hordechar));//Horde Orc oldu..
                }
            }
            foreach (Human h in humanList)
            {
                Console.WriteLine("Name: " + h.Name + " ID: " + h.ID + " Warrior: " + h.IsWarrior + " Priest: " + h.IsPriest);
            }

            foreach (Orc o in orcList)
            {
                Console.WriteLine("Name: " + o.Name + " ID: " + o.ID + " Warrior: " + o.IsWarrior + " Priest: " + o.IsPriest + " Hunter: " + o.IsHunter);
            }

            foreach (Undead u in undeadList)
            {
                Console.WriteLine("Name: " + u.Name + " ID: " + u.ID + " Warrior: " + u.IsWarrior + " Priest: " + u.IsPriest + " Hunter: " + u.IsHunter);
            }
            Console.Read();
        }
    }
}
