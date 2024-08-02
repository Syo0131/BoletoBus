using BoletoBus.Usuario.Application.Base;
using BoletoBus.Usuario.Application.Dtos;
using BoletoBus.Usuario.Application.Interfaces;
using BoletoBus.Usuario.Domain.Entities;
using BoletoBus.Usuario.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoletoBus.Usuario.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly ILogger<UsuarioService> logger;

        public UsuarioService(IUsuarioRepository usuarioRepository, ILogger<UsuarioService>logger)
        {
            this.usuarioRepository = usuarioRepository;
            this.logger = logger;
            
        }



        public ServiceResult GetUsuario()
        {
            var usuarios = usuarioRepository.GetAll();
            var usuariosDtos = usuarios.Select(r => new UsuarioDtoAdd
            {

                Nombres = r.Nombres,
                Apellidos = r.Apellidos,
                Correo = r.Correo,
                Clave = r.Clave,
                TipoUsuario = r.TipoUsuario,
                FechaCreacion = r.FechaCreacion,


            }).ToList();

            return new ServiceResult
            {
                Success = true,
                Message = "Usuario obtenido correctamente",
                Result = usuariosDtos
            };
        }

        public ServiceResult GetUsuarios(int id)
        {
            var usuarios = usuarioRepository.GetEntityBy(id);
            if (usuarios == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Usuario no encontrado"
                };
            }

            var UsuarioDto = new UsuarioDtoAdd
            {
                Nombres = usuarios.Nombres,
                Apellidos = usuarios.Apellidos,
                Correo = usuarios.Correo,
                Clave = usuarios.Clave,
                TipoUsuario = usuarios.TipoUsuario,
                FechaCreacion = usuarios.FechaCreacion,
            };

            return new ServiceResult
            {
                Success = true,
                Message = "Usuario obtenido correctamente",
                Result = UsuarioDto
            };
        }

        public ServiceResult GuardarUsuario(UsuarioSaveModel SaveUsuario)
        {
             var  user = new Domain.Entities.Usuario
            {
                Nombres = SaveUsuario.Nombres,
                Apellidos = SaveUsuario.Apellidos,
                Correo = SaveUsuario.Correo,
                Clave = SaveUsuario.Clave,
                TipoUsuario = SaveUsuario.TipoUsuario,
                FechaCreacion = SaveUsuario.FechaCreacion,
            };

            usuarioRepository.Save(user);
            return new ServiceResult
            {
                Success = true,
                Message = "usuario añadido con exito.",
            };
        }

        public ServiceResult UpdateUsuario(UsuarioUpdateModel usuarioupdate)
        {
            var Uusuario = usuarioRepository.GetEntityBy(usuarioupdate.IdUsuario);
            if (Uusuario == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Usuario no encontrado"
                };
            }

            Uusuario.Nombres = usuarioupdate.Nombres ?? Uusuario.Nombres;
            Uusuario.Apellidos = usuarioupdate.Apellidos ?? Uusuario.Apellidos;
            Uusuario.Correo = usuarioupdate.Correo ?? Uusuario.Correo;
            Uusuario.Clave = usuarioupdate.Clave ?? Uusuario.Clave;
            Uusuario.TipoUsuario = usuarioupdate.TipoUsuario ?? Uusuario.TipoUsuario;
            Uusuario.FechaCreacion = usuarioupdate.FechaCreacion ?? Uusuario.FechaCreacion;


            this.usuarioRepository.Update(Uusuario);
            return new ServiceResult
            {
                Success = true,
                Message = "Usuario actualizado con exito"
            };
        }
        public ServiceResult DeleteUsuario(UsuarioDeleteModel usuarioDelete)
        {
            var Dusuario = usuarioRepository.GetEntityBy(usuarioDelete.IdUsuario);
            if (Dusuario == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "USuario no encontrado"
                };
            }
            usuarioRepository.Delete(Dusuario);
            return new ServiceResult
            {
                Success = true,
                Message = "Usuario Elmininado con exito"
            };
        }
    }
}
