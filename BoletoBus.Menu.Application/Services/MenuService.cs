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
             
            var menus = menuRepository.GetAll();
            var menusDtos = menus.Select(r => new MenuDtoAdd
            {
                
                Nombre = r.Nombre,
                Descripcion = r.Descripcion,
                Precio = r.Precio,
                Categoria = r.Categoria
            }).ToList();

            return new ServiceResult
            {
                Success = true,
                Message = "Menu obtenido correctamente",
                Result = menusDtos
            };
        }

        public ServiceResult GetMenus(int id)
        {
            var menus = menuRepository.GetEntityBy(id);
            if (menus == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Menu no encontrado"
                };
            }

            var MenuDto = new MenuDtoAdd
            {
                Nombre = menus.Nombre,
                Descripcion = menus.Descripcion,
                Precio = menus.Precio,
                Categoria = menus.Categoria
            };

            return new ServiceResult
            {
                Success = true,
                Message = "Menu obtenido correctamente",
                Result = MenuDto
            };
        }

        public ServiceResult SaveMenu(MenuSaveModel savemenu)
        { 
            Domain.Entities.Menu menu = new Domain.Entities.Menu
            {
                Id = savemenu.IdPlato,
                Nombre = savemenu.Nombre,
                Descripcion = savemenu.Descripcion,
                Precio = savemenu.Precio,
                Categoria = savemenu.Categoria
            };

            this.menuRepository.Save(menu);
            return new ServiceResult
            {
                Success = true,
                Message = "Se añadio el menu correctamente.",
            };
        }

        public ServiceResult UpdateMenu(MenuUpdateModel menuUpdate)
        {
            var Umenu = menuRepository.GetEntityBy(menuUpdate.IdPlato);
            if (Umenu == null)
            {
                return new ServiceResult
                { 
                    Success = false,
                    Message = "Menu no encontrado"
                };
            }


            
            Umenu.Nombre = menuUpdate.Nombre ?? Umenu.Nombre;
            Umenu.Descripcion = menuUpdate.Descripcion ?? Umenu.Descripcion;
            Umenu.Precio = menuUpdate.Precio;
            Umenu.Categoria = menuUpdate.Categoria ?? Umenu.Categoria;
                

            this.menuRepository.Update(Umenu);
            return new ServiceResult
            {
                Success = true,
                Message = "Menu actualizado con exito"
            };

        }
        public ServiceResult DeleteMenu(MenuDeleteModel menudelete)
        {
            var Dmenu = menuRepository.GetEntityBy(menudelete.IdPlato);
            if (Dmenu == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Menu no encontrado"
                };
            }
            menuRepository.Delete(Dmenu);
            return new ServiceResult
            {
                Success = true,
                Message = "Menu Elmininado con exito"
            };
        }
    }

}
