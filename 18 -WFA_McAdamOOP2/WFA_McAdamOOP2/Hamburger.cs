using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdamOOP2
{
    public class Hambuger : McMenu
    {
        public string HambugerName { get; set; }
        public Dimensions Dimension { get; set; }

        public static List<Hambuger> hambugerList = new List<Hambuger>()
        {
            new Hambuger { HambugerName = "Whooper",Price = 25},
            new Hambuger { HambugerName = "SteakHouse",Price = 35},
            new Hambuger { HambugerName ="Chicken Buger",Price = 20}
        };

        //Methods
        public override string ToString()
        {
            return HambugerName;
        }

        public override void Add(object obj)
        {
            Hambuger h = (Hambuger)obj;
            hambugerList.Add(h);
        }

        public override void Delete(object obj)
        {
            Hambuger h = (Hambuger)obj;
            foreach (Hambuger hambuger in hambugerList)
            {
                if (hambuger.HambugerName == h.HambugerName)
                {
                    hambugerList.Remove(hambuger);
                    break;
                }
            }
        }

        public override void Update(object obj, string hamburgerName, decimal price)
        {
            Hambuger h = (Hambuger)obj;
            foreach (Hambuger hambuger in hambugerList)
            {
                if (hambuger.HambugerName == h.HambugerName)
                {
                    hambuger.HambugerName = hamburgerName;
                    hambuger.Price = price;
                }
            }
        }
    }
    public enum Dimensions
    {
        Küçük, Orta, Büyük
    }
}
