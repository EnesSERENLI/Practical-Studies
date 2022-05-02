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
    public class MoviesCategoriesService
    {
        ProjectContext db = new ProjectContext();

        //Add 
        public string AddMoviesCategories(int movieId, int categoryId)
        {
            try
            {
                MoviesCategory mc = new MoviesCategory();
                mc.MovieId = movieId;
                mc.CategoryId = categoryId;
                db.MoviesCategories.Add(mc);
                db.SaveChanges();
                return "MoviesCategories Added.!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //List
        public void ListMoviesCategories(ListView lv)
        {
            lv.Items.Clear();
            foreach (MoviesCategory mc in db.MoviesCategories)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = mc.ID.ToString();
                lvi.SubItems.Add(mc.MovieId.ToString());               
                lvi.SubItems.Add(mc.CategoryId.ToString());               
                lvi.Tag = mc;
                lv.Items.Add(lvi);
            }
        }
        public void ListMoviesCategories(ListView lsv, ListView lv)
        {
            foreach (ListViewItem lvi in lsv.Items)
            {
                MoviesCategory mc = (MoviesCategory)lvi.Tag;
                ListViewItem lvi2 = new ListViewItem();
                lvi2.Text = mc.ID.ToString();
                lvi2.SubItems.Add(mc.MovieId.ToString());
                int movieId = (int)mc.MovieId;
                Movie movie = db.Movies.FirstOrDefault(x => x.ID == mc.MovieId);
                lvi2.SubItems.Add(movie.MovieName);
                lvi2.SubItems.Add(mc.CategoryId.ToString());
                int categoryId = (int)mc.CategoryId;
                Category category = db.Categories.Find(categoryId);
                lvi2.SubItems.Add(category.CategoryName);
                lv.Items.Add(lvi2);
            }
        }

        //Update
        public string UpdateMoviesCategories(int id, int movieId, int categoryId)
        {
            MoviesCategory updated = db.MoviesCategories.FirstOrDefault(c => c.ID == id);
            updated.MovieId = movieId;
            updated.CategoryId = categoryId;
            db.SaveChanges();
            return "MoviesCategories Updated..!";
        }
        //Delete
        public string DeleteMoviesCategories(int id)
        {
            try
            {
                MoviesCategory deleted = db.MoviesCategories.Find(id);
                db.MoviesCategories.Remove(deleted);
                db.SaveChanges();
                return "MoviesCategories Deleted!";
            }
            catch (Exception ex)
            {
                return "You entered an undefined ID number.";
            }
        }
    }
}
