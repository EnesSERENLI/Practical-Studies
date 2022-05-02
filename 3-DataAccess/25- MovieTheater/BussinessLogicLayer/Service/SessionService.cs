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
    public class SessionService
    {
        ProjectContext db = new ProjectContext();

        //Add
        public string AddSession(string duration)
        {
            try
            {
                List<string> sessions = new List<string> { "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" };
                foreach (string time in sessions)
                {
                    if (duration == time)
                    {
                        if (!db.Sessions.Any(x => x.Duration == duration))
                        {
                            Session session = new Session();
                            session.Duration = duration;
                            db.Sessions.Add(session);
                            db.SaveChanges();
                            return "Session Added.!";
                        }
                        else
                        {
                            return "This session already defined!";
                        }
                    }
                }
                return "Duration format => AA:00 or AA:30";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //List
        public void SessionList(ListView lv)
        {
            lv.Items.Clear();
            foreach (Session s in db.Sessions)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.ID.ToString();
                lvi.SubItems.Add(s.Duration);
                lvi.Tag = s;
                lv.Items.Add(lvi);
            }
        }
        //Update
        public string UpdateSessions(int id, string duration)
        {

            List<string> sessions = new List<string> { "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" };

            foreach (string time in sessions)
            {
                if (!db.Sessions.Any(x => x.Duration == duration))
                {
                    if (duration == time)
                    {
                        try
                        {
                            Session updated = db.Sessions.FirstOrDefault(s => s.ID == id);
                            updated.Duration = duration;
                            db.SaveChanges();
                            return "Session Updated.!";
                        }
                        catch (Exception ex)
                        {
                            return "You entered an undefined ID number.";
                        }
                    }
                }
                else
                {
                    return "This session already defined!";
                }
            }
            return "Duration format => AA:00 or AA:30";
        }
        //Delete

        public string DeleteSession(int id)
        {
            try
            {
                Session deleted = db.Sessions.Find(id);
                db.Sessions.Remove(deleted);
                db.SaveChanges();
                return "Session Deleted!";
            }
            catch (Exception ex)
            {
                return "You entered an undefined SessionID number.";
            }
        }
    }
}
