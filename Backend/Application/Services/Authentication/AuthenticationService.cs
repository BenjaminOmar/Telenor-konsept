using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResultDto Register(string firstName, string lastName, string email, string password)
        {
            return new AuthenticationResultDto(Guid.NewGuid(), "firstName", "lastName", "email", "token");
        }

        public AuthenticationResultDto Login(string email, string password)
        {
            return new AuthenticationResultDto(Guid.NewGuid(), "firstName", "lastName", "email", "token");
        }
    }
}