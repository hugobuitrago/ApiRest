using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Takever.DTO;
using Takever.Service;
using Takever.Service.Interfaces;
using static Takever.Domain.Entities.TVShow;

namespace Takever.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private ITVShowService _tvShowService;
        
        //IUserService userService,
        public ShowController(ILogger<UserController> logger, ITVShowService tvShowService)
        {
            _tvShowService = tvShowService;
            _logger = logger;
           
        }

        [HttpPost]
        [Route("api/TVShow")]
        [Authorize]
        public async Task<IActionResult> Inserir(TVShowDTO tvShow)
        {
            try
            {
                var result = await _tvShowService.InsertTVShowAsync(tvShow);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet]
        [Route("api/TVShow")]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _tvShowService.GetAll();
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet]
        [Route("api/TVShow/FilterByGenre")]
        [Authorize]
        public async Task<IActionResult> GetTVShowWithFilterByGenre(GenreTVShow genre)
        {
            try
            {
                var result = await _tvShowService.GetTVShowWithFilterByGenre(genre);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }

        }


    }
}
