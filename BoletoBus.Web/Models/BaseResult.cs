namespace BoletoBus.Web.Models
{
    public class BaseResult<T>
    {
        public string? message { get; set; }
        public bool success { get; set; }
        public T Result { get; set; }
    }
}
