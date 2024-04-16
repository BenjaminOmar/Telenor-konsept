using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.Authentication
{
    public record AuthenticationResultDto(
        string Username,
        string Password);
}