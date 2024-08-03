using BoletoBus.Menu.Application.Dtos;
using BoletoBus.Mesa.Application.Dtos;
using BoletoBus.Web.Links;
using BoletoBus.Web.Models.Mesa;
using BoletoBus.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BoletoBus.Web.Controllers
{
    public class MesaController : Controller
    {
        private readonly ApiServices _services;
        private readonly URL_sConfiguration _URL_sConfiguration;

        public MesaController(ApiServices apiService, IOptions<URL_sConfiguration> options)
        {
            _services = apiService;
            _URL_sConfiguration = options.Value;
        }
        // GET: MesaController
        public async Task<ActionResult> Index()
        {
            var apiResponse = await _services.Get<List<MesaGetModelBase>>(_URL_sConfiguration.GetMesa);
            if (apiResponse.success)
            {
                return View(apiResponse.Result);
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(new List<MesaGetModelBase>());
            }
        }

        // GET: MesaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var apiResponse = await _services.Get<MesaGetModelBase>(_URL_sConfiguration.GetMesaById(id));
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

        // GET: MesaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MesaSaveModel savemesa)
        {
            if (!ModelState.IsValid)
            {
                return View(savemesa);
            }

            var apiResponse = await _services.Post(_URL_sConfiguration.SaveMesa, savemesa);

            if (apiResponse.success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(savemesa);
            }
        }

        // GET: MesaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var apiResponse = await _services.Get<MesaGetModelBase>(_URL_sConfiguration.GetMesaById(id));
            if (apiResponse.success)
            {
                var updatemesa = new MesaUpdateModel
                {

                    IdMesa = apiResponse.Result.IdMesa,
                    Estado = apiResponse.Result.Estado,
                    Capacidad = apiResponse.Result.Capacidad,


                };

                return View(updatemesa);
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return NotFound();
            }
        }

        // POST: MesaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MenuUpdateModel updatemesa)
        {
            if (!ModelState.IsValid)
            {
                return View(updatemesa);
            }

            var apiResponse = await _services.Post(_URL_sConfiguration.GetMesaById(id), updatemesa);

            if (apiResponse.success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(updatemesa);
            }
        }
    }
}
