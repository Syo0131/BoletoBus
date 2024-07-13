

using Microsoft.EntityFrameworkCore;

namespace BoletoBus.Menu.Persistence.Context
{
    public class BoletosBusContext : DbContext
    {
        #region "Constructor"
        public BoletosBusContext(DbContextOptions<BoletosBusContext> options) : base(options)
        {
        }
        #endregion

        #region "Db Sets"
        public DbSet<Domain.Entities.Menu> Menu { get; set; }

        #endregion
    }
}
