using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories;

public class CustomerRepository(DataContext context) : BaseRepository<Customer>(context), ICustomerRepository
{
    private readonly DataContext _context = context;
}