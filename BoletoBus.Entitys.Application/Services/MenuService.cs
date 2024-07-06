namespace BoletoBus.Entities.Application.services;

public class MenuService : IMenuService
{
    private readonly IMenuDb MenuDb;

    public MenuService(IMenuDb MenuDb)
    {
        this.MenuDb = MenuDb;
    }

    public ServiceResult DeleteMenu(MenuDeleteModel DeleteMenu)
    {
        ServiceResult result = new ServiceResult();

        try
        {
           
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.Message = "No se puedo eliminar los menus";
        }
        return result;
    }



    public ServiceResult GetMenus(int id)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            result.Data = this.MenuDb.GetMenu(id);
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.Message = "No se puedo obtener los usuarios";
        }
        return result;
    }

    public ServiceResult SaveMenu(MenuSaveModel SaveMenu)
    {
        ServiceResult result = new ServiceResult();

        try
        {
           
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.Message = "No se puedo guardar el menu";
        }
        return result;
    }

    public ServiceResult UpdateMenu(MenuUpdateModel UpdateMenu)
    {
        ServiceResult result = new ServiceResult();

        try
        {
            if (UpdateMenu is null)
            {
                result.Success = false;
                result.Message = "";
                return result;
            }
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.Message = "No se puedo actualizar los menu";
        }
        return result;
    }

    ServiceResult IMenuService.GetMenu()
    {
        ServiceResult result = new ServiceResult();

        try
        {
            result.Data = MenuDb.GetMenu();
        }
        catch (Exception ex)
        {
            result.Success = false;
            result.Message = "No se puedo obtener los menus";
        }
        return result;
    }
}
