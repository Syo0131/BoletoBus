
using BoletoBus.Menu.Domain.Interfaces;
using BoletoBus.Menu.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Menu.Persistence.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly BoletosBusContext context;

        public MenuRepository(BoletosBusContext context)
        {
            this.context = context;
        }
        public void Delete(Domain.Entities.Menu entity)
        {
            this.context.Menu.Remove(entity);
            this.context.SaveChanges();
        }

        public bool Exists(System.Linq.Expressions.Expression<Func<Domain.Entities.Menu, bool>> filter)
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

        public List<Domain.Entities.Menu> GetMenuByIdPlato(int IdPlato)
        {
            return this.context.Menu.Where(r => r.IdPlato == IdPlato).ToList();
        }

        public void Save(Domain.Entities.Menu entity)
        {
            try
            {
                Domain.Entities.Menu menu = new Domain.Entities.Menu
                {
                    IdPlato = entity.IdPlato,
                    Nombre = entity.Nombre,
                    Descripcion = entity.Descripcion,
                    Precio = entity.Precio,
                    Categoria = entity.Categoria
                };

                this.context.Menu.Add(menu);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al salvar el menu");
            }

        }

        public void Update(Domain.Entities.Menu entity)
        {
            var menu = this.context.Menu.Find(entity.IdPlato);

            menu.IdPlato = entity.IdPlato;
            menu.Nombre = entity.Nombre;
            menu.Descripcion = entity.Descripcion;
            menu.Precio = entity.Precio;
            menu.Categoria = entity.Categoria;

            this.context.Menu.Update(menu);
            this.context.SaveChanges();

        }
    }
}
