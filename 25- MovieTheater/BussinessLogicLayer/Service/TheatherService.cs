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
    public class TheatherService
    {
        ProjectContext db = new ProjectContext();

        //Add
        public string AddTheather(int movieId,int saloonId,int sessionId,int weekId)
        {
            try
            {
                Theater theater = new Theater();
                theater.MovieId = movieId;
                theater.SaloonId = saloonId;
                theater.SessionId = sessionId;
                theater.WeekId = weekId;
                db.Theaters.Add(theater);
                db.SaveChanges();
                return "Theater Added.!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //List
        public void TheatherList(ListView lv)
        {
            lv.Items.Clear();
            foreach (Theater t in db.Theaters)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = t.ID.ToString();
                lvi.SubItems.Add(t.MovieId.ToString());
                lvi.SubItems.Add(t.SaloonId.ToString());
                lvi.SubItems.Add(t.SessionId.ToString());
                lvi.SubItems.Add(t.WeekId.ToString());
                lvi.Tag = t;
                lv.Items.Add(lvi);
            }
        }
        //Update
        public string UpdateTheather(int id, int movieId, int saloonId, int sessionId, int weekId)
        {
            try
            {
                Theater updated = db.Theaters.Find(id);
                updated.MovieId = movieId;
                updated.SaloonId = saloonId;
                updated.SessionId = sessionId;
                updated.WeekId = weekId;
                db.SaveChanges();
                return "Theather Updated..!";
            }
            catch (Exception ex)
            {
                return "You entered an undefined SessionID number.";
            }
            
        }
        //Delete
        public string DeleteTheater(int id)
        {
            try
            {
                Theater deleted = db.Theaters.Find(id);
                db.Theaters.Remove(deleted);
                db.SaveChanges();
                return "Theater Deleted!";
            }
            catch (Exception ex)
            {
                return "You entered an undefined TheatherID number.";
            }
        }
        //Theather Details
        public void TheatherDetail(ListView lsv,FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            Theater t = (Theater)lsv.SelectedItems[0].Tag;
            ListView lv = new ListView();
            lv.Width = flp.Width;
            lv.Height = flp.Height;
            lv.Columns.Add("ThetherID", 175);
            lv.Columns.Add("MovieName", 210);
            lv.Columns.Add("SaloonName", 175);
            lv.Columns.Add("Session", 175);
            lv.Columns.Add("WeekName", 175);
            lv.View = View.Details;
            lv.GridLines = true;
            ListViewItem lvi = new ListViewItem();
            lvi.Text = t.ID.ToString();
            int movieId = (int)t.MovieId;
            Movie movie = db.Movies.FirstOrDefault(x=>x.ID==t.MovieId);
            lvi.SubItems.Add(movie.MovieName);
            int saloonId = (int)t.SaloonId;
            Saloon saloon = db.Saloons.Find(saloonId);
            lvi.SubItems.Add(saloon.SaloonName);
            int sessionId = (int)t.SessionId;
            Session session = db.Sessions.Find(sessionId);
            lvi.SubItems.Add(session.Duration);
            int weekId = (int)t.WeekId;
            Week week = db.Weeks.Find(weekId);
            lvi.SubItems.Add(week.WeekName);
            lv.Items.Add(lvi);
            flp.Controls.Add(lv);
        }
    }
}
