using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Session
    {
        public Session()
        {
                
        }
        public Session(string duration)
        {
            Duration = duration;
        }
        public int ID { get; set; }
        public string Duration { get; set; }
        public static List<Session> sessionList = new List<Session>();

        //Mapping
        public List<Theater> Theaters { get; set; }
    }
}
