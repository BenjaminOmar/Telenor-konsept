using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services.Authentication;
using Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var result = authenticationService.Register(request.Username, request.Name, request.Email, request.Password);

            return Ok(new AuthenticationResponse(result.Id, result.FirstName, result.LastName, result.Email, result.Token));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await authenticationService.Login(request.Username, request.Password);

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            if (result.ErrorCode == 404)
            {
                return NotFound(result.ErrorMessage);
            }

            return BadRequest(result.ErrorMessage);
        }
    }
}