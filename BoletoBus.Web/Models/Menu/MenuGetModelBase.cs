namespace BoletoBus.Web.Models.Menu
{
    public class MenuGetModelBase
    {
        public int IdPlato { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int Precio { get; set; }
        public string? Categoria { get; set; }
    }
}
