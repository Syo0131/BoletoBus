

using BoletoBus.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBus.Entities.Domain.Entities
{
    public class Menu : AuditEntity<int>
    {
        [Column("IdPlato")]
        public override int Id { get; set; }
        public int IdPlato { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Categoria { get; set; }
    }
}
