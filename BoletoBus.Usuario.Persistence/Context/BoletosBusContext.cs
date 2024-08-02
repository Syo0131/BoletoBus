
using Microsoft.EntityFrameworkCore;

namespace BoletoBus.Usuario.Persistence.Context
{
    public class BoletosBusContext : DbContext
    {
        #region "Constructor"
        public BoletosBusContext(DbContextOptions<BoletosBusContext> options) :base(options)
        {  
        }
        #endregion

        #region "Db Sets"

        public DbSet<Domain.Entities.Usuario> Usuario {get; set;}


        #endregion
    }
}
