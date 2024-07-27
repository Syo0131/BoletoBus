using BoletoBus.Usuario.Application.Dtos;
using BoletoBus.Usuario.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Usuario.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }


        // GET: api/<MenuController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.usuarioService.GetUsuario();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }

        }

        // GET api/<MenuController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = this.usuarioService.GetUsuarios(id);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<MenuController>
        [HttpPost]
        public IActionResult Post([FromBody] UsuarioSaveModel SaveUsuario)
        {
            var result = this.usuarioService.GuardarUsuario(SaveUsuario);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // PUT api/<MenuController>/5
        [HttpPut("{id}")]
        public IActionResult Put(UsuarioUpdateModel usuarioupdate)
        {
            var result = this.usuarioService.UpdateUsuario(usuarioupdate);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(UsuarioDeleteModel usuarioDelete)
        {
            var result = this.usuarioService.DeleteUsuario(usuarioDelete);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }

        }
    }
}
