using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ank16ProductApplication.DAL.Repository.Abstract
{
    public interface IRepository<T>
    {
        //CRUD İŞLEMLERİNİN OLABİLMESİ İÇİN GEREKLİ METOTLARIN BAŞLIĞINI TANIMLAYALIM.
        public void Add(T entity);
        public void Update(T entity);
        //statüsünü deleted yapma
        public void Delete(T entity);
        //veritabanında silme
        public void Remove(T entity);
        public IQueryable<T> GetAll();
        public T GetById(int id);
        public IQueryable Search(Expression<Func<T, bool>> predicate);
    }
}
