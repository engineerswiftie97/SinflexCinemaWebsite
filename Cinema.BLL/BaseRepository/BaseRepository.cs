using Cinema.BLL.IRepository;
using Cinema.DAL.Context;
using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BLL.BaseRepository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected SinFlexContext db = SinFlexContext.DBInstance;
        public void Add(T item)
        {
            db.Set<T>().Add( item);
            Save();

        }
        public void Save()
        {
            db.SaveChanges();
        }
        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);

        }

        public void Delete(T item)
        {
            item.Status = DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public object GetAnonymus(Expression<Func<T, object>> exp)
        {
            return db.Set<T>().Select(exp).ToList();
        }

        public T GetByID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public T GetByName(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).Single();
        }

        public List<T> SelectActives()
        {
            return db.Set<T>().Where(x => x.Status != DataStatus.Deleted).ToList();
        }

        public virtual List<T> SelectAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> SelectDeleteds()
        {
            return db.Set<T>().Where(x => x.Status == DataStatus.Deleted).ToList();
        }

        public List<T> SelectModifieds()
        {
            return db.Set<T>().Where(x => x.Status == DataStatus.Updated).ToList();
        }

        public void SpecialDelete(int id)
        {
            db.Set<T>().Remove(GetByID(id));
        }

        public void Update(T item)
        {
            item.ModifiedDate = DateTime.Now;
            item.Status = DataStatus.Updated;
            T toBeUpdated = GetByID(item.ID);
            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }
    }
}
