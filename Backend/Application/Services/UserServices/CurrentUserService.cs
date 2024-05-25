using System.Security.Claims;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Http;

namespace Application.Services.UserServices;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    
    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    public ClaimsPrincipal User => _httpContextAccessor.HttpContext?.User;

    public string UserId => User?.FindFirstValue(ClaimTypes.NameIdentifier);

    public string UserName => User?.Identity?.Name;
    
    
}