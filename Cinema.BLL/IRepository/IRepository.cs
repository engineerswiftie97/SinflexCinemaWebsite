using Cinema.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BLL.IRepository
{
    public interface IRepository<T> where T: BaseEntity
    {
        void Add(T item);

        void Delete(T item);

        void Update(T item);

        List<T> SelectAll();

        T GetByID(int id);

        void SpecialDelete(int id);

        List<T> SelectDeleteds();

        List<T> SelectModifieds();

        List<T> SelectActives();

        //db.Categories.Where(x=>x.ProductName=="Chai")

        T GetByName(Expression<Func<T, bool>> exp);

        //anonim bir tipte bir deger döndüren expression metodu

        //db.Products.Select(x=> new {})


        object GetAnonymus(Expression<Func<T, object>> exp);

        bool Any(Expression<Func<T, bool>> exp);

        List<T> Where(Expression<Func<T, bool>> exp);
    }
}
