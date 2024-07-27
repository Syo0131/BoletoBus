using BoletoBus.Menu.Application.Dtos;
using BoletoBus.Menu.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Menu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService menuService;
        public MenuController(IMenuService menuService)
        {
            this.menuService = menuService;
        }


        // GET: api/<MenuController>
        [HttpGet("GetMenu")]
        public IActionResult Get()
        {
            var result = this.menuService.GetMenu();
            if (!result.Success)
            
                return BadRequest(result);
            
            else
            
                return Ok(result);
            
            
        }

        // GET api/<MenuController>/5
        [HttpGet("GetMenubyId")]
        public IActionResult Get(int id)
        {
            var result = this.menuService.GetMenus(id);
            if (!result.Success)
            
                return BadRequest(result);
            
            else
            
                return Ok(result);
            
        }

        // POST api/<MenuController>
        [HttpPost("SaveMenu")]
        public IActionResult Post([FromBody] MenuSaveModel menuSave)
        {
            var result = this.menuService.SaveMenu(menuSave);
            if (!result.Success)
            
                return BadRequest(result);
            
            else
            
                return Ok(result);
            
        }

        // PUT api/<MenuController>/5
        [HttpPut("UpdateMenu")]
        public IActionResult Put(MenuUpdateModel menuUpdate)
        {
            var result = this.menuService.UpdateMenu(menuUpdate);
            if (!result.Success)
            
                return BadRequest(result);
            
            else
            
                return Ok(result);
            
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("DeleteMenu")]
        public IActionResult Delete(MenuDeleteModel menuDelete)
        {
            var result = this.menuService.DeleteMenu(menuDelete);
            if (!result.Success)
            
                return BadRequest(result);
            
            else
            
                return Ok(result);
            

        }
    }
}
