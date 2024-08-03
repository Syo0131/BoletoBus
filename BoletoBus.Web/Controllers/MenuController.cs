using BoletoBus.Menu.Application.Dtos;
using BoletoBus.Web.Links;
using BoletoBus.Web.Models.Menu;
using BoletoBus.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;


namespace BoletoBus.Web.Controllers
{
    public class MenuController : Controller
    {

        private readonly ApiServices _services;
        private readonly URL_sConfiguration _URL_sConfiguration;

        public MenuController(ApiServices apiService, IOptions<URL_sConfiguration> options)
        {
            _services = apiService;
            _URL_sConfiguration = options.Value;
        }
        // GET: MenuController
        public async Task<ActionResult> Index()
        {
            var apiResponse = await _services.Get<List<MenuGetModelBase>>(_URL_sConfiguration.GetMenu);
            if (apiResponse.success)
            {
                return View(apiResponse.Result);
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(new List<MenuGetModelBase>());
            }
        }

        // GET: MenuController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var apiResponse = await _services.Get<MenuGetModelBase>(_URL_sConfiguration.GetMenuById(id));
            if (apiResponse.success)
            {
                return View(apiResponse.Result);
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return NotFound();
            }
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MenuSaveModel Menusave)
        {
            if (!ModelState.IsValid)
            {
                return View(Menusave);
            }

            var apiResponse = await _services.Post(_URL_sConfiguration.SaveMenu, Menusave);

            if (apiResponse.success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(Menusave);
            }
        }

        // GET: MenuController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var apiResponse = await _services.Get<MenuGetModelBase>(_URL_sConfiguration.GetMenuById(id));
            if (apiResponse.success)
            {
                var updatemenu = new MenuUpdateModel
                {
                    
                    IdPlato = apiResponse.Result.IdPlato,
                    Nombre = apiResponse.Result.Nombre,
                    Descripcion = apiResponse.Result.Descripcion,
                    Precio = apiResponse.Result.Precio,
                    Categoria = apiResponse.Result.Categoria,
                    
                };

                return View(updatemenu);
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return NotFound();
            }
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MenuUpdateModel updatemenu)
        {
            if (!ModelState.IsValid)
            {
                return View(updatemenu);
            }

            var apiResponse = await _services.Post(_URL_sConfiguration.GetMenuById(id), updatemenu);

            if (apiResponse.success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(updatemenu);
            }
        }
    }
}
