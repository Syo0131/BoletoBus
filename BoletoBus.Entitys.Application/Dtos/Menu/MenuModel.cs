namespace BoletoBus.Entities.Application.Dtos.Menu
{
    public class MenuModel 
    {
        public int IdPlato {get; set;}
        public String? Nombre {get; set;}
        public String? Descripcion {get; set;}
        public decimal Precio {get; set;}
        public String? Categoria {get; set;}

    }
}