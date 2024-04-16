using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Helpers;

namespace Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResultDto Register(string username, string name, string email, string password);
        Task<Result<AuthenticationResultDto>> Login(string username, string password);
    }
}