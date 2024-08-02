
using BoletoBus.Usuario.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using BoletoBus.Usuario.Persistence.Context;
using System.Linq.Expressions;


namespace BoletoBus.Usuario.Persistence.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BoletosBusContext context;
        private readonly ILogger<UsuarioRepository> logger;
        public UsuarioRepository(BoletosBusContext context, ILogger<UsuarioRepository>logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public bool Exists(Expression<Func<Domain.Entities.Usuario, bool>> filter)
        {
            return this.context.Usuario.Any(filter);
        }

        public List<Domain.Entities.Usuario> GetAll()
        {
            return this.context.Usuario.ToList();
        }

        public Domain.Entities.Usuario GetEntityBy(int Id)
        {
            return this.context.Usuario.Find(Id);
        }

        public List<Domain.Entities.Usuario> GetUsuarioByIdUsuario(int Id)
        {
            return this.context.Usuario.Where(r => r.Id == Id).ToList();
        }

        public void Save(Domain.Entities.Usuario entity)
        {
            try
            {
                this.context.Usuario.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al salvar al usuario", ex);
            }
        }

        public void Update(Domain.Entities.Usuario entity)
        {
            try
            {
                this.context.Usuario.Update(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar el usuario");
            }
        }
        public void Delete(Domain.Entities.Usuario entity)
        {
            this.context.Usuario.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
