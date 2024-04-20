using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Application.Services.Authentication
{
    public record AuthenticationResultDto(string AccessToken, CookieOptions AccessTokenOptions);
}