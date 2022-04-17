using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Movie
    {
        public Movie()
        {

        }
        public Movie(string movieName, string desc, int duration)
        {
            MovieName = movieName;
            Description = desc;
            Duration = duration;
        }
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public static List<Movie> movieList = new List<Movie>();

        //Mapping

        //Bir filmin birden çok tiyatrosu olur...
        public List<Theater> Theaters { get; set; }
        //Bir filmin birden çok kategorisi olur...       
        public List<MoviesCategory> MoviesCategories { get; set; }

    }
}
