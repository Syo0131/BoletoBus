using BoletoBus.Menu.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Menu.Application.Interfaces
{
    public interface IMenuService
    {
        ServiceResult GetMenu();
        ServiceResult GetMenus();
        ServiceResult SaveMenu();
        ServiceResult UpdateMenu();
        ServiceResult DeleteMenu();
    }
}
