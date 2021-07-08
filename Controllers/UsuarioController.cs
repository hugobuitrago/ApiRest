using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Perfius.Business;
using Perfius.Data;
using Perfius.Hypermedia.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfius.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private IUsuarioBusiness _usuarioBusiness;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioBusiness usuarioBusiness)
        {
            _logger = logger;
            _usuarioBusiness = usuarioBusiness;
        }

        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_usuarioBusiness.GetAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var user = _usuarioBusiness.GetById(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Create([FromBody] UsuarioVO usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }
            return Ok(_usuarioBusiness.Create(usuario));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] UsuarioVO usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }
            return Ok(_usuarioBusiness.Update(usuario));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _usuarioBusiness.Delete(id);
            return NoContent();
        }

        [HttpPost("acessar")]
        public IActionResult Acessar()
        {
            return BadRequest("Não foi possível fazer o login");
        }
    }
}
