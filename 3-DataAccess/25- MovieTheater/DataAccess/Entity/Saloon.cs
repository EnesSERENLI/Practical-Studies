using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Saloon
    {
        public Saloon()
        {

        }
        public Saloon(string salonname, short capacity)
        {
            SaloonName = salonname;
            Capacity = capacity;
        }
        public int ID { get; set; }
        public string SaloonName { get; set; }
        public short Capacity { get; set; }
        public static List<Saloon> saloonList = new List<Saloon>();

        //Mapping
        public List<Theater> Theaters { get; set; }
    }
}
