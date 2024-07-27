using BoletoBus.Menu.Application.Base;
using BoletoBus.Menu.Application.Dtos;
using BoletoBus.Menu.Application.Interfaces;
using BoletoBus.Menu.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoletoBus.Menu.Application.Services
{
    
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository menuRepository;
        private readonly ILogger<MenuService> logger;


        public MenuService(IMenuRepository menuRepository, ILogger<MenuService> logger)
        {
            this.menuRepository = menuRepository;
            this.logger = logger;
        }

        public ServiceResult GetMenu()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var menus = this.menuRepository.GetAll();

                result.Result = (from menu in menus // Utiliza la variable menus en lugar de llamar nuevamente a menuRepository.GetAll()
                                 where menu.Deleted == false
                                 select new MenuModel
                                 {
                                     IdPlato = menu.IdPlato,
                                     Nombre = menu.Nombre,
                                     Descripcion = menu.Descripcion,
                                     Precio = menu.Precio,
                                     Categoria = menu.Categoria
                                 }).FirstOrDefault();
                if (result.Result == null)
                {
                    result.Success = false;
                    result.Message = "No se encontró ningún menú.";
                }
                else
                {
                    result.Success = true;
                    result.Message = "Menú obtenido exitosamente.";
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error obteniendo el menu.";
                this.logger.LogError(message: result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetMenus(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var menus = this.menuRepository.GetAll();

                result.Result = (from menu in menus // Utiliza la variable menus en lugar de llamar nuevamente a menuRepository.GetAll()
                                 where menu.Id == id && menu.Deleted == false
                                 select new MenuModel
                                 {
                                     IdPlato = menu.IdPlato,
                                     Nombre = menu.Nombre,
                                     Descripcion = menu.Descripcion,
                                     Precio = menu.Precio,
                                     Categoria = menu.Categoria
                                 }).FirstOrDefault();

                if (result.Result == null)
                {
                    result.Success = false;
                    result.Message = "No se encontró el menú con el ID especificado.";
                }
                else
                {
                    result.Success = true;
                    result.Message = "Menú obtenido exitosamente.";
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error obteniendo el menu.";
                this.logger.LogError(message: result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveMenu(MenuSaveModel? savemenu)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                if (savemenu == null)
                {
                    result.Success = false;
                    result.Message = "El modelo de menu a guardar no puede ser nulo";

                    return result;
                }


                Domain.Entities.Menu menu = new Domain.Entities.Menu
                {
                    IdPlato = savemenu.IdPlato,
                    Nombre = savemenu.Nombre,
                    Descripcion = savemenu.Descripcion,
                    Precio = savemenu.Precio,
                    Categoria = savemenu.Categoria
                };

                this.menuRepository.Save(menu);

                result.Success = true;
                result.Message = "Menú guardado exitosamente.";

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "No se pudo añadir al menu.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;

        }

        public ServiceResult UpdateMenu(MenuUpdateModel menuUpdate)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                Domain.Entities.Menu update = new Domain.Entities.Menu
                {
                    IdPlato = menuUpdate.IdPlato,
                    Nombre = menuUpdate.Nombre,
                    Descripcion = menuUpdate.Descripcion,
                    Precio = menuUpdate.Precio,
                    Categoria = menuUpdate.Categoria
                };
                this.menuRepository.Update(update);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error al actualizar el menu";
                this.logger.LogError (result.Message, ex.ToString());
            }
            return result;
        }
        public ServiceResult DeleteMenu(MenuDeleteModel menudelete)
        {
            throw new NotImplementedException();
        }
    }

}
