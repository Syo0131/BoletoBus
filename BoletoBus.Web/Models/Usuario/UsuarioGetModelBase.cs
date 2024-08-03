namespace BoletoBus.Web.Models.Usuario
{
    public class UsuarioGetModelBase
    {
        public int idUsuario { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string tipoUsuario { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
