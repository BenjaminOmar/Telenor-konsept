using System.Security.Claims;

namespace Domain.Interfaces.Services.User;

public interface ICurrentUserService
{
    ClaimsPrincipal User { get; }
    Guid UserId { get; }
    string UserName { get; }
    
    string Role { get; }

    Task<Entities.User?> GetUser();
}