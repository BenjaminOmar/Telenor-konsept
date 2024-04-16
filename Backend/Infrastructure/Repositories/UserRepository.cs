using Application.RepositoryInterfaces;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly DataContext _context;

    public UserRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    /// <summary>
    /// Retrieves a user by username asynchronously.
    /// </summary>
    /// <param name="username">The target username.</param>
    /// <returns>A User if found; otherwise, null.</returns>
    public async Task<User?> GetUser(string username, string password)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
    }

}