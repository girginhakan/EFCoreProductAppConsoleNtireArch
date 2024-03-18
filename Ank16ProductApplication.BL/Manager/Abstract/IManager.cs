using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ank16ProductApplication.BL.Manager.Abstract
{
    public interface IManager<TModel> where TModel : class
    {
        public void Add(TModel model);
        public void Update(TModel model);
        //statüsünü deleted yapma
        public void Delete(TModel model);
        //veritabanında silme
        public void Remove(TModel model);
        public List<TModel> GetAll();
        public TModel GetById(int id);
        public IQueryable Search(Expression<Func<TModel, bool>> predicate);
    }
}
