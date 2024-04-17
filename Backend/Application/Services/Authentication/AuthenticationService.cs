using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task<Result<AuthenticationResultDto>> Register(string username, string name, string email, string phoneNumber, string password, Guid role)
        {
            if (await _userRepository.CheckUserExists(username))
            {
                return Result<AuthenticationResultDto>.Failure("Brukernavnet er allerede i bruk", 400);
            }

            if (!await _userRepository.CheckRoleExists(role))
            {
                return Result<AuthenticationResultDto>.Failure("Rollen eksisterer ikke", 400);
            }

            string passwordMessage = CheckPasswordStrength(password);

            if (passwordMessage != "")
            {
                return Result<AuthenticationResultDto>.Failure(passwordMessage, 400);
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = username,
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber,
                Password = BCrypt.Net.BCrypt.HashPassword(password),
                RoleId = role
            };

            user.CreatedBy = user.Id;
            user.CreatedOn = DateTime.UtcNow;

            await _userRepository.Add(user);

            var authResult = new AuthenticationResultDto(user.Username, user.Password, user.RoleId.ToString());
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

            var authResult = new AuthenticationResultDto(user.Username, user.Password, user.RoleId.ToString());
            return Result<AuthenticationResultDto>.Success(authResult);
        }


        /// <summary>
        /// Checks the strength of a password and returns a message indicating any shortcomings.
        /// </summary>
        /// <param name="password">The password to check for strength.</param>
        /// <returns>
        /// A string message detailing the issues found with the password. If the password fails the
        /// basic length requirement, it returns a message indicating that the password must be at least
        /// 8 characters long. If the password meets the length requirement but lacks any letters, it
        /// returns a message stating that the password must contain at least one letter. If the password
        /// passes all checks, an empty string is returned.
        /// </returns>
        private static string CheckPasswordStrength(string password)
        {
            StringBuilder sb = new();

            if (!password.Any(c => char.IsLetter(c)))
            {
                sb.Append("Passord må inneholde minst en bokstav");
            }

            if (password.Length < 8)
            {
                sb.Clear();
                sb.Append("Passord må være minst 8 tegn langt");
            }

            return sb.ToString();
        }
    }
}