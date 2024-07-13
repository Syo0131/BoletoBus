namespace BoletoBus.Mesa.Application.Dtos
{
    public abstract class MesaBaseModel
    {
        public int IdMesa { get; set; }
        public int Capacidad { get; set; }
        public string? Estado { get; set; }
    }
}
