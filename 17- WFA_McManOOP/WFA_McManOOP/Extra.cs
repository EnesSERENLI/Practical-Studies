using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McManOOP
{
    public class Extra: Menus
    {
        public string ExtraName { get; set; }

        public static List<Extra> extraList = new List<Extra>()
        {
            new Extra { ExtraName = "Kethcup",Price = 2},
            new Extra { ExtraName = "Ranch",Price = 2},
            new Extra { ExtraName ="Mayonnaise",Price = 2},
            new Extra { ExtraName = "G.Mayonnaise",Price = 2},
            new Extra { ExtraName = "Buffalo",Price = 2},
            new Extra { ExtraName = "Chaddar",Price = 2}
        };
        public override string ToString()
        {
            return ExtraName +" ";
        }

        public override void Add(object obj)
        {
            Extra extra = (Extra)obj;
            extraList.Add(extra);
        }

        public override void Delete(object obj)
        {
            Extra ex = (Extra)obj;
            foreach (Extra extra in extraList)
            {
                if (extra.ExtraName == ex.ExtraName)
                {
                    extraList.Remove(extra);
                    break;
                }
            }
        }

        public override void Update(object obj, string extraName, decimal price)
        {
            Extra ex = (Extra)obj;
            foreach (Extra extra in extraList)
            {
                if (extra.ExtraName == ex.ExtraName)
                {
                    extra.ExtraName = extraName;
                    extra.Price = price;
                }
            }
        }
    }
}
