namespace BoletoBus.Web.Models
{
    public class BaseGetResult<G> : BaseResult
    {
        public G Result { get; set; }
    }
}
