using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract;
using EasyCashIdentity.CoreLayer.EasyCashIdentity.DataAccessLayer.Abstract;

namespace EasyCashIdentity.CoreLayer.EasyCashIdentity.DataAccessLayer.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            var context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            var context = new TContext();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            var context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public TEntity GetById(int id)
        {
            var context = new TContext();
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            var context = new TContext();
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            var context = new TContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}