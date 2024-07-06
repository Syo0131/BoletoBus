

using System.Linq.Expressions;

namespace BoletoBus.Common.Data.Repository
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll(TEntity entity);
        TEntity GetEntityBy(TType Id);
        bool Exists(Expression<Func<TEntity, bool>>filter);
    }
}
