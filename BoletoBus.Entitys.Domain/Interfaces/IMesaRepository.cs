using BoletoBus.Common.Data.Repository;


namespace BoletoBus.Entities.Domain.Interfaces
{
    public interface IMesaRepository : IBaseRepository<Domain.Entities.Mesa, int>
    {
        List<Domain.Entities.Mesa> GetMesaByIdMesa(int IdMesa);
    }
}
