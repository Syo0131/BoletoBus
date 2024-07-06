using BoletoBus.Common.Data.Repository;

namespace BoletoBus.Entities.Domain.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository <Domain.Entities.Usuario, int>
    {
        List<Domain.Entities.Usuario> GetUsuarioByIdUsuario(int IdUsuario);
    }
}
