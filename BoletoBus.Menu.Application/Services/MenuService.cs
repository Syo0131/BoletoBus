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
        public ServiceResult DeleteMenu(MenuDeleteModel deletemenu)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetMenu()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetMenus(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = menuRepository.GetEntityBy(id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "No se pudo añadir al usuario.";
                this.logger.LogError(result.Message, ex.ToString);

            }
            return result;
        }

        ServiceResult SaveMenu(MenuSaveModel savemenu)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.Menu menu = new Domain.Entities.Menu();
                this.menuRepository.Save(menu);

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "No se pudo añadir al usuario.";
                this.logger.LogError(result.Message, ex.ToString);
            }
            return result;
        }

        public ServiceResult UpdateMenu(MenuUpdateModel updatemenu)
        {
            throw new NotImplementedException();
        }

        ServiceResult IMenuService.SaveMenu(MenuSaveModel savemenu)
        {
            throw new NotImplementedException();
        }
    }

}
