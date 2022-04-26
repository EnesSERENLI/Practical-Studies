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
    public class WeekService
    {
        ProjectContext db = new ProjectContext();

        //Add
        public string AddWeek(string weekName,DateTime firstDay,DateTime lastDay)
        {
            try
            {
                Week w = new Week();
                w.WeekName = weekName;
                w.WeekFirstDay = firstDay;
                w.WeekLastDay = lastDay;
                db.Weeks.Add(w);
                db.SaveChanges();
                return "Week Added.!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //List
        public void WeekList(ListView lv)
        {
            lv.Items.Clear();
            foreach (Week w in db.Weeks)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = w.ID.ToString();
                lvi.SubItems.Add(w.WeekName);
                lvi.SubItems.Add(w.WeekFirstDay.ToShortDateString());
                lvi.SubItems.Add(w.WeekLastDay.ToShortDateString());
                lvi.Tag = w;
                lv.Items.Add(lvi);
            }
        }
        //Update
        public string UpdateWeek(int id, string weekName,DateTime firstDay,DateTime lastDay)
        {
            Week updated = db.Weeks.FirstOrDefault(w => w.ID == id);
            updated.WeekName = weekName;
            updated.WeekFirstDay = firstDay;
            updated.WeekLastDay = lastDay;
            db.SaveChanges();
            return "Week Updated..!";
        }
        //Delete
        public string DeleteWeek(int id)
        {
            try
            {
                Week deleted = db.Weeks.Find(id);
                db.Weeks.Remove(deleted);
                db.SaveChanges();
                return "Week Deleted!";
            }
            catch (Exception ex)
            {
                return "You entered an undefined WeekID number.";
            }
        }
    }
}
