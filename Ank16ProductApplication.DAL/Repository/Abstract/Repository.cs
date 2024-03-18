using Ank16ProductApplication.DAL.Context;
using Ank16ProductApplication.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank16ProductApplication.DAL.Repository.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly ProductDbContext _db;
        private DbSet<T> entities;

        //Kısa süreliğine durcak
        public Repository(ProductDbContext db)
        {
            _db = db;
            entities = _db.Set<T>();
        }
        public void Add(T entity)
        {
            entity.Status = Status.Created;
            entity.CreatedDate = DateTime.Now;

            entities.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            //statusunu deleted yapacak ama tablodan silmeyecek
            entity.DeletedDate = DateTime.Now;
            entity.Status &= ~Status.Deleted;
            Update(entity);

        }
        public void Remove(T entity)
        {
            //gerçekten veitabanından silinecek
            entities.Remove(entity);
            _db.SaveChanges();
        }
        public IQueryable<T> GetAll()
        {
            return entities.Where(e => e.Status != Status.Deleted).AsNoTracking();
        }

        public T GetById(int id)
        {
            //silinenleri getirmemesi lazım statusu deleted olmayalar gelmeli
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.Status != Status.Deleted);
        }



        public IQueryable Search(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            //silinenleri getirmeyecek
            var all = entities.AsNoTracking().Where(e=>e.Status!=Status.Deleted);
            return all.Where(predicate);
        }

        public void Update(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entities.Update(entity);
            _db.SaveChanges();
        }



    }
}
