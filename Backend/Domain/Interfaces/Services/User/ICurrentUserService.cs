using System.Security.Claims;

namespace Domain.Interfaces.Services.User;

public interface ICurrentUserService
{
    ClaimsPrincipal User { get; }
    string UserId { get; }
    string UserName { get; }
}