

using BoletoBus.Common.Data.Repository;
using BoletoBus.Entities.Domain.Entities;

namespace BoletoBus.Entities.Domain.Interfaces
{
    public interface IMenuRepository : IBaseRepository<Domain.Entities.Menu, int >
    {
        List<Domain.Entities.Menu> GetMenuByIdPlato(int IdPlato);

    }
}
