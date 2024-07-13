

using BoletoBus.Common.Data.Repository;


namespace BoletoBus.Menu.Domain.Interfaces
{
    public interface IMenuRepository : IBaseRepository<Domain.Entities.Menu, int >
    {
        List<Domain.Entities.Menu> GetMenuByIdPlato(int IdPlato);

    }
}
