using BoletoBus.Usuario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Usuario.Persistence.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Delete(Domain.Entities.Usuario entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Domain.Entities.Usuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Usuario GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Usuario> GetMesaByIdMesa(int IdMesa)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entities.Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entities.Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
