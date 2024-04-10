using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.Authentication
{
    public record AuthenticationResultDto(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token);
}