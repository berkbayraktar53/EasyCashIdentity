using System.Linq.Expressions;

namespace EasyCashIdentity.CoreLayer.EasyCashIdentity.BusinessLayer.Abstract
{
    public interface IEntityService<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetList();
    }
}