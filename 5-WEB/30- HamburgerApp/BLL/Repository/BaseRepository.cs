using BLL.Interface;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        ProjectContext db = new ProjectContext();
        public string Create(T model)
        {
            string result = "";
            try
            {
                db.Set(typeof(T)).Add(model);
                db.SaveChanges();
                result = $"Data added";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }

        public string Delete(int id)
        {
            string result = "";
            try
            {
                var deleted = db.Set(typeof(T)).Find(id);
                if (deleted is Hamburger)
                {
                    Hamburger hamburger = (Hamburger)deleted;
                    hamburger.IsActive = false;
                }
                else if (deleted is Extra)
                {
                    Extra extra = (Extra)deleted;
                    extra.IsActive = false;
                }
                db.SaveChanges();
                result = $"Data deleted";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }

        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public string Update(T model)
        {
            string result = "";
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                model.IsActive = true;
                db.SaveChanges();
                result = "Data updated";
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }
    }
}
