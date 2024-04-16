using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.RepositoryInterfaces;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> GetUser(string username, string password);
}