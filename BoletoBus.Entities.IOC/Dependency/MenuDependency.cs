using BoletoBus.Menu.Domain.Interfaces;
using BoletoBus.Menu.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace BoletoBus.Menu.IOC.Dependency
{
    public static class MenuDependency
    {
        public static void AddMenuDependency(this IServiceCollection service) 
        {
            #region"Repositorios"
            service.AddScoped<IMenuRepository, MenuRepository>();
            #endregion
            #region"Services"
            service.AddTransient<IMenuRepository, MenuRepository>();
            #endregion
        }
    }
}
