using BoletoBus.Mesa.Application.Dtos;
using BoletoBus.Mesa.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Mesa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaController : ControllerBase
    {
        private readonly IMesaService mesaService;
        public MesaController(IMesaService mesaService)
        {
            this.mesaService =mesaService;
        }


        // GET: api/<MenuController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.mesaService.GetMesa();
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
            var result = this.mesaService.GetMesas(id);
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
        public IActionResult Post([FromBody] MesaSaveModel mesaSave)
        {
            var result = this.mesaService.SaveMesa(mesaSave);
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
        public IActionResult Put(MesaUpdateModel mesaUpdate)
        {
            var result = this.mesaService.ActualizarMesa(mesaUpdate);
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
        public IActionResult Delete(MesaDeleteModel mesaDelete)
        {
            var result = this.mesaService.DeleteMesa(mesaDelete);
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
