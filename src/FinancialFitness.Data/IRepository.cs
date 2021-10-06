using System;
using System.Linq;
using System.Linq.Expressions;

namespace FinancialFitness.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity input);
        void Delete(TEntity input);
        IQueryable<TEntity> FindAll();
        IQueryable<TEntity> FindAllByCondition(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        void Update(TEntity input);
    }
}