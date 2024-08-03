namespace BoletoBus.Web.Models.Menu
{
    public class MenuGetModelBase
    {
        public int IdPlato { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public int precio { get; set; }
        public string? categoria { get; set; }
    }
}
