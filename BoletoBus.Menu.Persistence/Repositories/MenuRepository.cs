
using BoletoBus.Menu.Domain.Interfaces;
using BoletoBus.Menu.Persistence.Context;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace BoletoBus.Menu.Persistence.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly BoletosBusContext context;
        private readonly ILogger<MenuRepository> logger;

        public MenuRepository(BoletosBusContext context, ILogger<MenuRepository>logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public bool Exists(Expression<Func<Domain.Entities.Menu, bool>> filter)
        {
            return this.context.Menu.Any(filter);
        }

        public List<Domain.Entities.Menu> GetAll()
        {
            return this.context.Menu.ToList();
        }

        public Domain.Entities.Menu GetEntityBy(int Id)
        {
            return this.context.Menu.Find(Id);
        }

        public List<Domain.Entities.Menu> GetMenuByIdPlato(int Id)
        {
            return this.context.Menu.Where(r => r.Id == Id).ToList();
        }

        public void Save(Domain.Entities.Menu entity)
        {
            try
            {
                this.context.Menu.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al salvar el menu", ex);
            }

        }

        public void Update(Domain.Entities.Menu entity)
        {
            try
            {
                this.context.Menu.Update(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar el menu", ex);
            }
        }
        public void Delete(Domain.Entities.Menu entity)
        {
            this.context.Menu.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
