using Domain.Repositories.Base;
using Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Logic.Services.Base
{
    public class ServiceBase<T> : IServiceBase<T>
        where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Delete(T entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public void Delete(object id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            return _repository.Get(filter, orderBy, includeProperties);
        }

        public T GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        public void Insert(T entity)
        {
            _repository.Insert(entity);
        }

        public void Update(T entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }
    }
}
