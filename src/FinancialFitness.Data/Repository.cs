using System;
using System.Linq;
using System.Linq.Expressions;

namespace FinancialFitness.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly FinancialFitnessDBContext DataContext;
        public Repository(FinancialFitnessDBContext dataContext)
        {
            this.DataContext = dataContext;
        }

        public void Create(TEntity input)
        {
            this.DataContext.Add<TEntity>(input);
            this.DataContext.SaveChanges();
        }

        public void Delete(TEntity input)
        {
            this.DataContext.Remove<TEntity>(input);
            this.DataContext.SaveChanges();
        }

        public IQueryable<TEntity> FindAll()
        {
            return this.DataContext.Set<TEntity>();
        }

        public IQueryable<TEntity> FindAllByCondition(Expression<Func<TEntity, bool>> predicate)
        {
            return this.DataContext.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return this.DataContext.Set<TEntity>().FirstOrDefault(predicate);
        }

        public void Update(TEntity input)
        {
            this.DataContext.Update<TEntity>(input);
            this.DataContext.SaveChanges();
        }
    }
}
