using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditoriaApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AuditoriaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditoriaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Repositorio.Repositorio.GetAuditorias());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var auditoria = Repositorio.Repositorio.GetAuditorias().FirstOrDefault(a => a.Id == id);

            if(auditoria == null)
                return NotFound();

            return StatusCode(302, auditoria);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AuditoriaViewModel _viewModel)
        {
            try
            {
                if(!ModelState.IsValid)
                    return BadRequest(ModelState);

                return Ok("Sucesso");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }
    }
}