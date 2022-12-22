using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Takever.DTO;
using Takever.Service.Interfaces;

namespace Takever.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private IUserService _userService;
        private ITokenService _tokenService;
        
        public UserController(ILogger<UserController> logger, IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _logger = logger;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("api/User")]
        [AllowAnonymous]
        public async Task<IActionResult> Insert(UserDTO user)
        {
            try
            {
                var result = await _userService.InsertUserAsync(user);
                var token = _tokenService.GenerateToken(result);
                result.Token = token;

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }

        }

        
    }
}
