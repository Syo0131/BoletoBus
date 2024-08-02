public class Rootobject
{
    public string message { get; set; }
    public bool success { get; set; }
    public Result[] result { get; set; }
}

public class Result
{
    public int idPlato { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public int precio { get; set; }
    public string categoria { get; set; }
}
namespace BoletoBus.Web.Models.Menu
{
    public class MenuGetModel
    {
    }
}
