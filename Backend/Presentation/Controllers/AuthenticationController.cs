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
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var result = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);

            return Ok(new AuthenticationResponse(result.Id, result.FirstName, result.LastName, result.Email, result.Token));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = _authenticationService.Login(request.Email, request.Password);

            return Ok(new AuthenticationResponse(result.Id, result.FirstName, result.LastName, result.Email, result.Token));
        }
    }
}