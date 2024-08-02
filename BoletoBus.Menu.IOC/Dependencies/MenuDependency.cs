using BoletoBus.Menu.Application.Interfaces;
using BoletoBus.Menu.Application.Services;
using BoletoBus.Menu.Domain.Interfaces;
using BoletoBus.Menu.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Menu.IOC.Dependencies
{
    public static class MenuDependency
    {
        public static void AddMenuDependency(this IServiceCollection service)
        {
            service.AddScoped<IMenuRepository, MenuRepository>();
            service.AddTransient<IMenuService, MenuService>();
        }


    }
}
