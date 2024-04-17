using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;
using Domain.Entities;
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

        public async Task<Result<AuthenticationResultDto>> Register(string username, string name, string email, string phoneNumber, string password)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = username,
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber,
                Password = BCrypt.Net.BCrypt.HashPassword(password),
            };

            user.CreatedBy = user.Id;
            user.CreatedOn = DateTime.UtcNow;

            await _userRepository.Add(user);

            var authResult = new AuthenticationResultDto(user.Username, user.Password);
            return Result<AuthenticationResultDto>.Success(authResult);
        }


        public async Task<Result<AuthenticationResultDto>> Login(string username, string password)
        {

            var user = await _userRepository.GetUser(username);

            if (user is null)
            {
                return Result<AuthenticationResultDto>.Failure("Bruker ikke funnet", 404);
            }

            bool validPassword = BCrypt.Net.BCrypt.Verify(password, user.Password);

            if (!validPassword)
            {
                return Result<AuthenticationResultDto>.Failure("Bruker ikke funnet", 401);
            }

            if (user.IsDeleted)
            {
                return Result<AuthenticationResultDto>.Failure("Brukeren er slettet", 401);
            }

            var authResult = new AuthenticationResultDto(user.Username, user.Password);
            return Result<AuthenticationResultDto>.Success(authResult);
        }
    }
}