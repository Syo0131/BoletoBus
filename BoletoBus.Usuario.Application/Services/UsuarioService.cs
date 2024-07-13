using BoletoBus.Usuario.Application.Base;
using BoletoBus.Usuario.Application.Dtos;
using BoletoBus.Usuario.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoletoBus.Usuario.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioService UsuarioRepository;
        private readonly ILogger<UsuarioService> logger;

        public ServiceResult DeleteUsuario(UsuarioDeleteModel usuarioDelete)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetUsuario()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetUsuarios(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult SaveUsuario(UsuarioSaveModel SaveUsuario)
        {
            throw new NotImplementedException();
        }

        public ServiceResult UpdateUsuario(UsuarioUpdateModel usuarioupdate)
        {
            throw new NotImplementedException();
        }
    }
}
