using Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class IdentityContext: IdentityDbContext<User>
{
    public IdentityContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
}