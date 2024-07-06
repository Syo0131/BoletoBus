

using BoletoBus.Common.Data.Repository;
using BoletoBus.Entities.Domain.Entities;

namespace BoletoBus.Entities.Domain.Interfaces
{
    public interface IMenuRepository : IBaseRepository<Menu, menu >
    {
        List<Menu> GetAll();

    }
}
