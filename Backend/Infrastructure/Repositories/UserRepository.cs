using Application.RepositoryInterfaces;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserRepository(DataContext context) : BaseRepository<User>(context), IUserRepository
{
    private readonly DataContext _context = context;
    private readonly IQueryable<User> _userQuery = context.Users.Where(u => !u.IsDeleted);

    /// <summary>
    /// Retrieves a user by username asynchronously.
    /// </summary>
    /// <param name="username">username to check</param>
    /// <returns>bool</returns>
    public Task<bool> CheckUserExists(string username)
    {
        return _userQuery.AnyAsync(x => x.Username == username);
    }

    /// <summary>
    /// Retrieves a user by username asynchronously.
    /// </summary>
    /// <param name="username">The target username.</param>
    /// <returns>A User if found; otherwise, null.</returns>
    public async Task<User?> GetUser(string username)
    {
        return await _userQuery
            .Include(r => r.Role)
            .FirstOrDefaultAsync(x => x.Username == username);
    }

    /// <summary>
    /// Checks if a role exists in the database based on the provided role ID.
    /// </summary>
    /// <param name="roleId">The unique identifier of the role to be checked.</param>
    /// <returns>
    /// A task that represents the asynchronous operation, containing a boolean result.
    /// True if the role exists; otherwise, false.
    /// </returns>
    public Task<bool> CheckRoleExists(Guid roleId)
    {
        return _context.Roles.AnyAsync(x => x.Id == roleId);
    }

}