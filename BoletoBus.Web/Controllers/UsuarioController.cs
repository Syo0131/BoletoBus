using BoletoBus.Usuario.Application.Dtos;
using BoletoBus.Web.Links;
using BoletoBus.Web.Models.Usuario;
using BoletoBus.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BoletoBus.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApiServices _services;
        private readonly URL_sConfiguration _URL_sConfiguration;

        public UsuarioController(ApiServices apiService, IOptions<URL_sConfiguration> options)
        {
            _services = apiService;
            _URL_sConfiguration = options.Value;
        }
        // GET: UsuarioController
        public async Task<ActionResult> Index()
        {
            var apiResponse = await _services.Get<List<UsuarioGetModelBase>>(_URL_sConfiguration.GetUsuario);
            if (apiResponse.success)
            {
                return View(apiResponse.Result);
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(new List<UsuarioGetModelBase>());
            }
        }

        // GET: UsuarioController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var apiResponse = await _services.Get<UsuarioGetModelBase>(_URL_sConfiguration.GetUsuarioById(id));
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

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UsuarioSaveModel usuariosave)
        {
            if (!ModelState.IsValid)
            {
                return View(usuariosave);
            }

            var apiResponse = await _services.Post(_URL_sConfiguration.SaveUsuario, usuariosave);

            if (apiResponse.success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(usuariosave);
            }
        }

        // GET: UsuarioController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var apiResponse = await _services.Get<UsuarioGetModelBase>(_URL_sConfiguration.GetUsuarioById(id));
            if (apiResponse.success)
            {
                var updatemenu = new UsuarioUpdateModel
                {
                    IdUsuario = apiResponse.Result.IdUsuario,
                    Nombres = apiResponse.Result.Nombres,
                    Apellidos = apiResponse.Result.Apellidos,
                    Correo = apiResponse.Result.Correo,
                    Clave = apiResponse.Result.Clave,
                    TipoUsuario = apiResponse.Result.TipoUsuario,
                    FechaCreacion = apiResponse.Result.FechaCreacion,
                };

                return View(updatemenu);
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return NotFound();
            }
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, UsuarioUpdateModel updateusuario)
        {
            if (!ModelState.IsValid)
            {
                return View(updateusuario);
            }

            var apiResponse = await _services.Post(_URL_sConfiguration.GetUsuarioById(id), updateusuario);

            if (apiResponse.success)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, apiResponse.message);
                return View(updateusuario);
            }
        }
    }
}
