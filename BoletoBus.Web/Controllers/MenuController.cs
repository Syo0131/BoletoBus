using BoletoBus.Web.http;
using BoletoBus.Web.Models.Menu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace BoletoBus.Web.Controllers
{
    public class MenuController : Controller
    {

        private readonly ApiHelper _apiHelper;

        public MenuController(ApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        // GET: MenuController
        public async Task<ActionResult> Index()
        {

            var url = "http://localhost:5145/api/Menu/GetMenu";
            var menuListGetResult = await _apiHelper.GetApiResponseAsync<MenuListGetResult>(url);

            if (!menuListGetResult.success)
            {
                ViewBag.Message = menuListGetResult.message;
                return View();
            }
            return View(menuListGetResult.Result ?? new List<MenuGetModelBase>());

        }

        // GET: MenuController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var url = $"http://localhost:5145/api/Menu/GetMenubyId?id={id}";
            var menuGetResult = await _apiHelper.GetApiResponseAsync<MenuGetResult>(url);

            if (!menuGetResult.success)
            {
                ViewBag.Message = menuGetResult.message;
                return View();
            }
            return View(menuGetResult.Result);

        }

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                var url = "http://localhost:5145/api/Menu/SaveMenu";
                var menuGetResult = await _apiHelper.GetApiResponseAsync<MenuGetResult>(url);

                if (!menuGetResult.success)
                {
                    ViewBag.Message = menuGetResult.message;
                    return View();
                }

            }
            catch
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
