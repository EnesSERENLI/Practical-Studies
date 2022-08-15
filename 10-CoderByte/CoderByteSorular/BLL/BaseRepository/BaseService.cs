using DAL.Abstract;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BaseRepository
{
    public abstract class BaseService<T> where T : BaseEntity
    {
        EkomProjectContext db = new EkomProjectContext();
        //Add
        public string Add(T model)
        {
            try
            {
                model.ID = Guid.NewGuid();
                db.Set<T>().Add(model);
                db.SaveChanges();
                return "Data Added!";
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //List
        public List<T> GetList()
        {
            return db.Set<T>().Cast<T>().ToList();
        }

        public List<T> GetDefaults(Expression<Func<T,bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }
        //Update
        public string Update(T model)
        {
            try
            {
                T updated = GetById(model.ID);
                DbEntityEntry entity = db.Entry(updated);
                if (entity != null)
                    entity.CurrentValues.SetValues(model);

                //db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Data Updated!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Delete
        public string Delete(Guid id)
        {
            try
            {
                T deleted = GetById(id);
                if (deleted != null)
                {
                    deleted.Status = DAL.Enums.Status.Deleted;
                    Update(deleted);
                    return "Data deleted!";
                }
                return "Data not found!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Find
        public T GetById(Guid id)
        {
            return db.Set<T>().Find(id);
        }
        //Any
        public bool Any(Expression<Func<T,bool>> exp)
        {
            bool result = db.Set<T>().Any(exp);
            return result;
        }
    }
}
