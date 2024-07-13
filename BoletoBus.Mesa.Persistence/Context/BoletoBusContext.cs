

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BoletoBus.Mesa.Persistence.Context
{
    public class BoletosBusContext : DbContext
    {
        #region "Constructor"
        public BoletosBusContext(DbContextOptions<BoletosBusContext> options) : base(options)
        {
        }
        #endregion

        #region "Db Sets"
        public DbSet<Domain.Entities.Mesa> Mesa { get; set; }

        #endregion
    }
}
