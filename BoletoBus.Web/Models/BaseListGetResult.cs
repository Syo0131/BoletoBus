namespace BoletoBus.Web.Models
{
    public class BaseListGetResult<L> : BaseResult
    {
        public List<L> Result { get; set; }

    }
}
