using BoletoBus.Entities.Application.Base;
using BoletoBus.Entities.Application.Dtos.Menu;
namespace BoletoBus.Entities.Application.Interfaces
{
    public interface IMenuService
    {
        ServiceResult GetMenu();
        ServiceResult GetMenus(int id);
        ServiceResult SaveMenu(MenuSaveModel SaveMenu);
        ServiceResult UpdateMenu(MenuUpdateModel UpdateMenu);
        ServiceResult DeleteMenu(MenuDeleteModel DeleteMenu);
    }
}