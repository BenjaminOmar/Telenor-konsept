using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResultDto Register(string username, string name, string email, string password);
        AuthenticationResultDto Login(string username, string password);
    }
}