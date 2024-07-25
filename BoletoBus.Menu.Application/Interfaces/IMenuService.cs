using BoletoBus.Menu.Application.Base;
using BoletoBus.Menu.Application.Dtos;


namespace BoletoBus.Menu.Application.Interfaces
{
    public interface IMenuService
    {
        ServiceResult GetMenu();
        ServiceResult GetMenus(int id);
        ServiceResult SaveMenu(MenuSaveModel savemenu);
        ServiceResult UpdateMenu(MenuUpdateModel menuUpdate);
        ServiceResult DeleteMenu(MenuDeleteModel menudelete);
        
    }
}
