using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs.Authentication;
using Domain.Helpers;


namespace Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<Result<bool>> Register(string username, string name, string? email, string? phoneNumber, string password, Guid role);
        Task<Result<AuthenticationResultDto>> Login(string username, string password);
    }
}