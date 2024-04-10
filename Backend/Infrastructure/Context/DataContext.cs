using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
}