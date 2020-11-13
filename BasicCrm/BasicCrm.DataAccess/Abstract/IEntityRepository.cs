using BasicCrm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BasicCrm.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        T Get(T entity);
        List<T> GetAll(T entity);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
