using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessLogicLayer.Service
{

    public class MovieService
    {
        ProjectContext db = new ProjectContext();

        //Movie Add
        public string AddMovie(string movieName, string description, int duration)
        {
            try
            {
                Movie movie = new Movie();
                movie.MovieName = movieName;
                movie.Description = description;
                movie.Duration = duration;
                db.Movies.Add(movie);
                db.SaveChanges();
                return "Movie Added.!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Movie List
        public void MovieList(ListView lv)
        {
            lv.Items.Clear();
            foreach (Movie m in db.Movies)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.ID.ToString();
                lvi.SubItems.Add(m.MovieName);
                lvi.SubItems.Add(m.Description);
                lvi.SubItems.Add(m.Duration.ToString());
                lvi.Tag = m;
                lv.Items.Add(lvi);
            }
        }
        public void MovieList(ListView lv, int id)
        {
            lv.Items.Clear();
            List<Movie> movies = new List<Movie>();
            List<MoviesCategory> moviesCategories;
            moviesCategories = db.MoviesCategories.Where(x => x.Category.ID == id).ToList();
            foreach (MoviesCategory mc in moviesCategories)
            {
                foreach (Movie m in db.Movies)
                {
                    if (mc.MovieId == m.ID)
                    {
                        movies.Add(m);
                    }
                }
            }
            foreach (Movie m in movies)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.ID.ToString();
                lvi.SubItems.Add(m.MovieName);
                lvi.SubItems.Add(m.Description);
                lvi.SubItems.Add(m.Duration.ToString());
                lvi.Tag = m;
                lv.Items.Add(lvi);
            }
        }
        //Movie Update
        public string UpdateMovie(int id, string movieName, int duration, string description)
        {
            Movie updated = db.Movies.FirstOrDefault(x => x.ID == id);
            updated.MovieName = movieName;
            updated.Description = description;
            updated.Duration = duration;
            db.SaveChanges();
            return "Movie Updated.!";
        }
        public string UpdateMovie(int id, string movieName, int duration)
        {
            Movie updated = db.Movies.FirstOrDefault(x => x.ID == id);
            updated.MovieName = movieName;
            updated.Duration = duration;
            db.SaveChanges();
            return "Movie Updated.!";
        }
        public string UpdateMovie(int id, string movieName)
        {
            try
            {
                Movie updated = db.Movies.FirstOrDefault(x => x.ID == id);
                updated.MovieName = movieName;
                db.SaveChanges();
                return "Movie Updated.!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
           
        }
        //Movie Delete
        public string DeleteMovie(int id)
        {
            try
            {
                Movie movie = db.Movies.Find(id);
                db.Movies.Remove(movie);
                db.SaveChanges();
                return "Movie Deleted!";
            }
            catch (Exception ex)
            {
                return "You entered an undefined MovieID number.";
            }
        }
        //Movie Sorting
        public void MovieSorting(bool val, ListView lv)
        {
            List<Movie> movies = new List<Movie>();
            foreach (ListViewItem lvi in lv.Items)
            {
                Movie movie = (Movie)lvi.Tag;
                movies.Add(movie);
            }
            if (val)
            {
                movies = movies.OrderBy(x => x.Duration).ToList();
            }
            else
            {
                movies = movies.OrderByDescending(x => x.Duration).ToList();
            }
            lv.Items.Clear();
            foreach (Movie m in movies)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.ID.ToString();
                lvi.SubItems.Add(m.MovieName);
                lvi.SubItems.Add(m.Description);
                lvi.SubItems.Add(m.Duration.ToString());
                lvi.Tag = m;
                lv.Items.Add(lvi);
            }
        }
        //Serial Movies
        public void SerialMovies(ListView lv)
        {
            lv.Items.Clear();
            List<Movie> movies;
            movies = db.Movies.Where(x => x.MovieName.Contains("john wick")).ToList();
            foreach (Movie m in movies)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.ID.ToString();
                lvi.SubItems.Add(m.MovieName);
                lvi.SubItems.Add(m.Description);
                lvi.SubItems.Add(m.Duration.ToString());
                lvi.Tag = m;
                lv.Items.Add(lvi);
            }
        }
        //Top Five Movie
        public void FiveMovie(ListView lv)
        {
            lv.Items.Clear();
            List<Movie> movies;
            movies = db.Movies.Where(x => x.MovieName == "green book" || x.MovieName == "The Hateful Eight" || x.MovieName == "The Shawshank Redemption" || x.MovieName == "Whiplash" || x.MovieName == "Forrest Gump").ToList();
            foreach (Movie m in movies)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.ID.ToString();
                lvi.SubItems.Add(m.MovieName);
                lvi.SubItems.Add(m.Description);
                lvi.SubItems.Add(m.Duration.ToString());
                lvi.Tag = m;
                lv.Items.Add(lvi);
            }
        }
        //Watch Before u Die
        public void WatchBeforeDie(ListView lv)
        {
            lv.Items.Clear();
            List<Movie> movies;
            movies = db.Movies.Where(x => x.MovieName == "green book" || x.MovieName == "The Hateful Eight" || x.MovieName == "The Shawshank Redemption" || x.MovieName == "Whiplash" || x.MovieName == "Forrest Gump" || x.MovieName == "Fight Club" || x.MovieName == "John Wick 1" || x.MovieName == "The Departed" || x.MovieName == "American History X").ToList();
            foreach (Movie m in movies)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.ID.ToString();
                lvi.SubItems.Add(m.MovieName);
                lvi.SubItems.Add(m.Description);
                lvi.SubItems.Add(m.Duration.ToString());
                lvi.Tag = m;
                lv.Items.Add(lvi);
            }
        }
        //Searchhing by Category
        public void ListWithCategory(ComboBox cmb)
        {
            cmb.DisplayMember = "CategoryName";
            cmb.ValueMember = "ID";
            cmb.DataSource = db.Categories.ToList();
        }
        //Searching by MovieName
        public void SearchMovie(ListView lv, string param)
        {
            lv.Items.Clear();
            List<Movie> movies = db.Movies.Where(x => x.MovieName.Contains(param)).ToList();
            foreach (Movie m in movies)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.ID.ToString();
                lvi.SubItems.Add(m.MovieName);
                lvi.SubItems.Add(m.Description);
                lvi.SubItems.Add(m.Duration.ToString());
                lvi.Tag = m;
                lv.Items.Add(lvi);
            }
        }
    }
}
