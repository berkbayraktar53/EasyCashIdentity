using System.Linq.Expressions;
using EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract;

namespace EasyCashIdentity.CoreLayer.EasyCashIdentity.DataAccessLayer.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
    }
}