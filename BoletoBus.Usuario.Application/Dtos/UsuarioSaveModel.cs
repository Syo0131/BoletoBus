namespace BoletoBus.Usuario.Application.Dtos
{
    public class UsuarioSaveModel 
    {

        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? TipoUsuario { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}