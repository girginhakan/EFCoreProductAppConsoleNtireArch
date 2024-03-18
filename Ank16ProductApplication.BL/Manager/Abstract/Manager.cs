using Ank16ProductApplication.DAL.Repository.Abstract;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ank16ProductApplication.BL.Manager.Abstract
{
    public abstract class Manager<TModel, TEntity> : IManager<TModel> where TModel : class
                                                                        where TEntity : class
    {
        private IMapper _mapper;
        protected IRepository<TEntity> _repository;
        protected MapperConfiguration _config;

        public Manager()
        {
            _config = new MapperConfiguration(cfg =>
           cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap());
            _mapper = new Mapper(_config);
        }

        public void Add(TModel model)
        {
            TEntity cevrilenEntity = _mapper.Map<TEntity>(model);
            _repository.Add(cevrilenEntity);
        }

        public void Update(TModel model)
        {
            TEntity cevrilenEntity = _mapper.Map<TEntity>(model);
            _repository.Update(cevrilenEntity);
        }

        public void Delete(TModel model)
        {
            TEntity cevrilenEntity = _mapper.Map<TEntity>(model);
            _repository?.Delete(cevrilenEntity);
        }

        public void Remove(TModel model)
        {
            TEntity cevrilenEntity = _mapper.Map<TEntity>(model);
            _repository.Remove(cevrilenEntity);
        }
        public List<TModel> GetAll()
        {
            List<TEntity> entitiesFromDb = _repository.GetAll().ToList();
            List<TModel> models = new List<TModel>();
            foreach (TEntity entity in entitiesFromDb)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }
            return models;

        }

        public TModel GetById(int id)
        {
            TEntity entity= _repository.GetById(id);
            TModel model = _mapper.Map<TModel>(entity);
            return model;
        }

        public IQueryable Search(Expression<Func<TModel, bool>> predicate)
        {
            Expression<Func<TEntity,bool>> predicateEntities = _mapper.Map<Expression<Func<TEntity,bool>>>(predicate);

            //Expression<Func<TEntity,bool>>
        }


    }
}
