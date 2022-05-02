using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Theater
    {
        public Theater()
        {

        }
        public Theater(int movieId,int sessionId,int saloonId,int weekId)
        {
            MovieId = movieId;
            SaloonId = saloonId;
            SessionId = sessionId;
            WeekId = weekId;
        }
        public int ID { get; set; }

        public static List<Theater> theatherList = new List<Theater>();
        //Mapping
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int SaloonId { get; set; }
        public Saloon Saloon { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        public int WeekId { get; set; }
        public Week Week { get; set; }

    }
}
