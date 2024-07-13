using BoletoBus.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Usuario.Domain.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Domain.Entities.Usuario, int>
    {
        List<Domain.Entities.Usuario> GetMesaByIdMesa(int IdMesa);
    
    }
}
