

using BoletoBus.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBus.Mesa.Domain.Entities
{
    public class Mesa : AuditEntity<int>
    {
        [Column("IdMesa")]
        public override int Id { get; set; }
        public int IdMesa { get; set; }
        public int Capacidad { get; set; }
        public string? Estado { get; set; }
    }
}
