namespace BoletoBus.Mesa.Persistence.Models
{
    public abstract class MesaBaseModel
    {
        public int IdMesa { get; set; }
        public int Capacidad { get; set; }
        public String? Estado { get; set; }
    }
}
