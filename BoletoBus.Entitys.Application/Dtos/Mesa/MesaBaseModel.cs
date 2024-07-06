namespace BoletoBus.Entities.Application.Dtos.Mesa
{
    public abstract class MesaBaseModel
    {
        public int IdMesa { get; set; }
        public int Capacidad { get; set; }
        public String? Estado { get; set; }
    }
}
