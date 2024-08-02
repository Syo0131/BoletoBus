

using BoletoBus.Common.Data.Base;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBus.Menu.Domain.Entities
{
    public class Menu : BaseEntity<int>
    {
        [Column("IdPlato")]
        public override int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Categoria { get; set; }

    }
}
