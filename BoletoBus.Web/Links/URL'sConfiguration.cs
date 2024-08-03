namespace BoletoBus.Web.Links
{
    public class URL_sConfiguration
    {
        public string? MenuURL { get; set; }
        public string? UsuarioURL { get; set; }
        public string? MesaURL { get; set; }


        // Menu URL's
        public string GetMenu => $"{MenuURL}/api/Menu/GetMenu";
        public string GetMenuById(int id) => $"{MenuURL}/api/Menu/GetMenuById?id={id}";
        public string SaveMenu => $"{MenuURL}/api/Menu/SaveMenu";
        public string UpdateMenu(int id) => $"{MenuURL}/api/Menu/UpdateMenu";

        // Menu URL's
        public string GetUsuario => $"{UsuarioURL}/api/Usuario/GetUsuario";
        public string GetUsuarioById(int id) => $"{UsuarioURL}/api/Usuario/GetUsuarioById?id={id}";
        public string SaveUsuario => $"{UsuarioURL}/api/Menu/SaveUsuario";
        public string UpdateUsuario(int id) => $"{UsuarioURL}/api/Usuario/UpdateUsuario";
       

        // Menu URL's
        public string GetMesa => $"{MesaURL}/api/Mesa/GetMesa";
        public string GetMesaById(int id) => $"{MesaURL}/api/Mesa/GetMesaById?id={id}";
        public string SaveMesa => $"{MesaURL}/api/Menu/SavaMesa";
        public string UpdateMesa(int id) => $"{MesaURL}/api/Mesa/UpdateMesa";
        
    }
}
