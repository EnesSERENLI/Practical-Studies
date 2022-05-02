using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Week
    {
        public Week()
        {

        }
        public Week(string weekname,DateTime weekFirstDay, DateTime weekLastDay)
        {
            WeekName = weekname;
            WeekFirstDay = weekFirstDay;
            WeekLastDay = weekLastDay;
        }
        public int ID { get; set; }
        public string WeekName { get; set; }
        public DateTime WeekFirstDay { get; set; }
        public DateTime WeekLastDay { get; set; }

        public static List<Week> weekList = new List<Week>();
        //Mapping

        public List<Theater> Theaters { get; set; }
    }
}
