using Domain.Entities;

namespace Application.RepositoryInterfaces;

public interface IUserRepository
{
    Task<User?> GetUser(string username);
}