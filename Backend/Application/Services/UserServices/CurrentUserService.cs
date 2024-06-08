using System.Security.Claims;
using Application.RepositoryInterfaces;
using Domain.Entities;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Http;

namespace Application.Services.UserServices;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IUserRepository _userRepository;
    
    public CurrentUserService(IHttpContextAccessor httpContextAccessor, IUserRepository userRepository)
    {
        _httpContextAccessor = httpContextAccessor;
        _userRepository = userRepository;
    }
    public ClaimsPrincipal User => _httpContextAccessor.HttpContext?.User!;

    public Guid UserId => Guid.Parse(User?.FindFirstValue(ClaimTypes.NameIdentifier)!);

    public string UserName => User?.Identity?.Name!;
    
    public string Role => User.FindFirst(ClaimTypes.Role)?.Value!;
    
    public Guid BusinessId => Guid.Parse(User.FindFirst("businessId")?.Value!);

    public async Task<User?> GetUser()
    {
        return await _userRepository.GetById(UserId);
    }


}