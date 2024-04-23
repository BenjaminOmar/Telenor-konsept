using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services.Authentication;
using Contracts.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        [Authorize]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var result = await authenticationService.Register(request.Username, request.Name, request.Email, request.PhoneNumber, request.Password, request.RoleId);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await authenticationService.Login(request.Username, request.Password);

            if (result.IsSuccess)
            {
                return Ok(new { Message = "Vellykket inlogging", Token = result.Value.AccessToken});
            }

            if (result.ErrorCode == 404)
            {
                return NotFound(result);
            }

            return BadRequest(result);
        }
    }
}