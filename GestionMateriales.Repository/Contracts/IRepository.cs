using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GestionMateriales.Repository.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Edit(TEntity entity);

        void Remove(TEntity entity);

        TEntity FindById(int Id);

        TEntity FindOne(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> FindAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] include);
    }
}
