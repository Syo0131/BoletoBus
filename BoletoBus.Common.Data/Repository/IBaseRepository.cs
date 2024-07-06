

using System.Linq.Expressions;

namespace BoletoBus.Common.Data.Repository
{
    /// <summary>
    /// Interfaces base para los repositorios de datos.
    /// </summary>
    /// <typeparam name="TEntity">Entidad con la que se va a trabajar</typeparam>
    /// <typeparam name="TType">Id por donde se va a buscar</typeparam>
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        void Save(TEntity entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        List<TEntity> GetAll(TEntity entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        TEntity GetEntityBy(TType Id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        bool Exists(Expression<Func<TEntity, bool>>filter);
        
    }
}
