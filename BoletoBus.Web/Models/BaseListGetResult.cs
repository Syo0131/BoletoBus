using BoletoBus.Web.Models.Mesa;

namespace BoletoBus.Web.Models
{
    public class BaseListGetResult<L> : BaseResult<MesaGetModelBase>
    {
        public List<L> Result { get; set; }

    }
}
