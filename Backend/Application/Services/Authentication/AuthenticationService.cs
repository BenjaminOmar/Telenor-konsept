using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Domain.Helpers;

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
        
        
        public async Task<Result<AuthenticationResultDto>> Login(string username, string password)
        {
            var user = await _userRepository.GetUser(username);

            if (user is null)
            {
                return Result<AuthenticationResultDto>.Failure("Bruker ikke funnet", 404);
            }
            
            var authResult = new AuthenticationResultDto(Guid.NewGuid(), "firstName", "lastName", "email", "token");
            return Result<AuthenticationResultDto>.Success(authResult);
        }
    }
}