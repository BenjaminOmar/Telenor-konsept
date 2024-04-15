using Application.RepositoryInterfaces;
using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly DataContext _context;
    
    public UserRepository(DataContext context) : base(context)
    {
        _context = context;
    }
    
    
}