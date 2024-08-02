namespace BoletoBus.Menu.Application.Dtos
{
    public abstract class MenuBase 
    {
        
        public String? Nombre {get; set;}
        public String? Descripcion {get; set;}
        public decimal Precio {get; set;}
        public String? Categoria {get; set;}

    }
}