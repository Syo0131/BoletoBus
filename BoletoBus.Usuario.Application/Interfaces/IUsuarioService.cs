
using BoletoBus.Usuario.Application.Base;
using BoletoBus.Usuario.Application.Dtos;

namespace BoletoBus.Usuario.Application.Interfaces
{
    public interface IUsuarioService
    {
        ServiceResult GetUsuario();
        ServiceResult GetUsuarios(int id);
        ServiceResult SaveUsuario(UsuarioSaveModel SaveUsuario);
        ServiceResult UpdateUsuario(UsuarioUpdateModel usuarioupdate);
        ServiceResult DeleteUsuario (UsuarioDeleteModel usuarioDelete);

    }                 
}
                    