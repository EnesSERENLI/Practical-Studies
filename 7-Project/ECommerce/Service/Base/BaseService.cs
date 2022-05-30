using Core;
using Core.Service;
using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Service.Base
{
    public class BaseService<T> : ICoreService<T> where T : EntityRepository
    {
        EcommerceContext context = DbContextSingleton.Context;
        public EcommerceContext GetContext()
        {
            return context;
        }
        //Ekleme
        public string Add(T model)
        {
            //todo: her veri kaydedildiğinde created propertyleri doldurulacak.
            //todo: her veri kaydedildiğinde created IP adresi yakalacak.
            try
            {
                model.ID = Guid.NewGuid();
                context.Set<T>().Add(model);
                context.SaveChanges();
                return "Veri eklendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        //Liste şeklinde ekleme
        public string Add(List<T> models)
        {
            foreach (var item in models)
            {
                context.Set<T>().Add(item);
            }
            context.SaveChanges();
            return "Veriler Eklendi!";
        }
        //İçeriyormu
        public bool Any(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().Any(exp);
        }
        //Silmiş gibi gösterme
        public string Delete(Guid id)
        {
            //id ile beraber getbyid kullan geleni update'e gonder
            try
            {
                T deleted = GetById(id);
                deleted.Status = Core.Enums.Status.Deleted; //Durumunu deleted olarak yap. Deleted olanlar listelenmicek. Kullanıcı silinmiş sanacak.
                Update(deleted);
                return "Veri silindi!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Bulma
        public T GetById(Guid id)
        {
            return context.Set<T>().Find(id);
        }
        //Kritere göre getirme
        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().Where(exp).ToList();
        }
        //Listeleme
        public List<T> GetList()
        {
            return context.Set(typeof(T)).Cast<T>().ToList();
        }
        //Silme
        public string RemoveForce(T model)
        {
            try
            {
                context.Set<T>().Remove(model);
                context.SaveChanges();
                return "Veri kalıcı olarak silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Güncelleme
        public string Update(T model)
        {
            try 
            {
                T updated = GetById(model.ID);
                //context.Entry(updated).State = System.Data.Entity.EntityState.Modified; singleton yüzünden sıkıntı çıkarıyor olabilir..
                DbEntityEntry entity =context.Entry(updated);
                entity.CurrentValues.SetValues(model);
                //context.Entry(updated).CurrentValues.SetValues(model);
                context.SaveChanges();
                return $"{model.ID} nolu veri güncellendi!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
