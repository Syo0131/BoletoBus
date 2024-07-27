using BoletoBus.Usuario.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using BoletoBus.Usuario.Application.Interfaces;
using BoletoBus.Usuario.Application.Services;
using BoletoBus.Usuario.Persistence.Repository;

namespace BoletoBus.Usuario.IOC.Dependency
{
    public static class UsuarioDependency
    {
        public static void AddUsuarioDependency(this IServiceCollection service) 
        { 
            service.AddScoped<IUsuarioRepository, UsuarioRepository>();
            service.AddTransient<IUsuarioService, UsuarioService>();

        }
    }
}
