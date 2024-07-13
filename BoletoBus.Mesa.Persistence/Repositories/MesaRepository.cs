

using BoletoBus.Mesa.Domain.Interfaces;
using System.Linq.Expressions;

namespace BoletoBus.Mesa.Persistence.Repositories
{
    public class MesaRepository : IMesaRepository
    {
        public void Delete(Domain.Entities.Mesa entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Domain.Entities.Mesa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Mesa> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Mesa GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Mesa> GetMesaByIdMesa(int IdMesa)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entities.Mesa entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entities.Mesa entity)
        {
            throw new NotImplementedException();
        }
    }
}
