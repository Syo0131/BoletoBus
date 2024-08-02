using BoletoBus.Common.Data.Repository;


namespace BoletoBus.Mesa.Domain.Interfaces
{
    public interface IMesaRepository : IBaseRepository<Entities.Mesa, int>
    {
        List<Entities.Mesa> GetMesaByIdMesa(int IdMesa);
 
    }
}
