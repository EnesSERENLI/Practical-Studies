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
    public class SaloonService
    {
        ProjectContext db = new ProjectContext();

        //Add
        public string AddSaloon(string saloonName,short capacity)
        {
            try
            {
                Saloon saloon = new Saloon();
                saloon.SaloonName = saloonName;
                saloon.Capacity = capacity;
                db.Saloons.Add(saloon);
                db.SaveChanges();
                return "Saloon Added.!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //List
        public void SaloonList(ListView lv)
        {
            lv.Items.Clear();
            foreach (Saloon s in db.Saloons)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.ID.ToString();
                lvi.SubItems.Add(s.SaloonName);
                lvi.SubItems.Add(s.Capacity.ToString());
                lvi.Tag = s;
                lv.Items.Add(lvi);
            }
        }
        //Update
        public string UpdateSaloon(int id, string saloonName, short capacity)
        {
            Saloon updated = db.Saloons.FirstOrDefault(s => s.ID == id);
            updated.SaloonName = saloonName;
            updated.Capacity = capacity;
            db.SaveChanges();
            return "Saloon Updated..!";
        }
        //Delete
        public string DeleteSaloon(int id)
        {
            try
            {
                Saloon deleted = db.Saloons.Find(id);
                db.Saloons.Remove(deleted);
                db.SaveChanges();
                return "Saloon Deleted!";
            }
            catch (Exception ex)
            {
                return "You entered an undefined SaloonID number.";
            }
        }
    }
}
