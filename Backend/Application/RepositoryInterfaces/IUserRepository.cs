using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.RepositoryInterfaces;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> GetUser(string username);

    Task<bool> CheckUserExists(string email);

    Task<bool> CheckRoleExists(Guid roleId);
}