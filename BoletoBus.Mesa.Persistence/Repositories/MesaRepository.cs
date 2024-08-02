

using BoletoBus.Mesa.Domain.Interfaces;
using BoletoBus.Mesa.Persistence.Context;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace BoletoBus.Mesa.Persistence.Repositories
{
    public class MesaRepository : IMesaRepository
    {
        private readonly BoletosBusContext context;
        private readonly ILogger<MesaRepository> logger;
        public MesaRepository (BoletosBusContext context, ILogger<MesaRepository>logger)
        {
            this.context = context;
            this.logger = logger;
        }


        public bool Exists(Expression<Func<Domain.Entities.Mesa, bool>> filter)
        {
            return this.context.Mesa.Any(filter);
        }

        public List<Domain.Entities.Mesa> GetAll()
        {
            return this.context.Mesa.ToList();
        }

        public Domain.Entities.Mesa GetEntityBy(int Id)
        {
            return this.context.Mesa.Find(Id);
        }

        public List<Domain.Entities.Mesa> GetMesaByIdMesa(int Id)
        {
            return this.context.Mesa.Where(r => r.Id == Id).ToList();
        }

        public void Save(Domain.Entities.Mesa entity)
        {
            try
            {
                this.context.Mesa.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al añadir la mesa", ex);
            }


        }

        public void Update(Domain.Entities.Mesa entity)
        {

            try
            {
                this.context.Mesa.Update(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar la mesa", ex);
            }
        }
        public void Delete(Domain.Entities.Mesa entity)
        {
            this.context.Mesa.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
