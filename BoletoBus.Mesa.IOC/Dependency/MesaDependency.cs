using BoletoBus.Mesa.Application.Interfaces;
using BoletoBus.Mesa.Application.Services;
using BoletoBus.Mesa.Domain.Interfaces;
using BoletoBus.Mesa.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Mesa.IOC.MesaDependency
{
    public static class MesaDependency
    {
        public static void AddMesaDependency(this IServiceCollection service)
        {
            service.AddScoped<IMesaRepository, MesaRepository>();
            service.AddTransient<IMesaService, MesaService>();
        }
    }
}
