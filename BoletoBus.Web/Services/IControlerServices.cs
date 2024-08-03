using BoletoBus.Menu.Application.Dtos;
using BoletoBus.Web.Models;
using BoletoBus.Web.Models.Menu;
using BoletoBus.Web.Models.Mesa;
using BoletoBus.Web.Services.Core;

namespace BoletoBus.Web.Services
{
    public interface IControlerServices : IBaseServices<MenuListGetResult, BaseResult<MesaGetModelBase>, MenuSaveModel, MenuUpdateModel>
    {

    }
}
