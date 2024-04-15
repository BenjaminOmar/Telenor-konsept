using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public AuthenticationResultDto Register(string username, string name, string email, string password)
        {
            return new AuthenticationResultDto(Guid.NewGuid(), "firstName", "lastName", "email", "token");
        }

        public AuthenticationResultDto Login(string username, string password)
        {
            return new AuthenticationResultDto(Guid.NewGuid(), "firstName", "lastName", "email", "token");
        }
    }
}