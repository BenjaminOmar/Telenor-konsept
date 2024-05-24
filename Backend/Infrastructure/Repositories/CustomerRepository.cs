using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.DTOs.Customer;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CustomerRepository(DataContext context, IMapper mapper) : BaseRepository<Customer>(context), ICustomerRepository
{
    private readonly DataContext _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<List<CustomerListResponseDto>> GetCustomerList()
    {
        IQueryable<Customer> customerQuery = _context.Customers;

        return await customerQuery
            .OrderByDescending(c => c.CreatedOn)
            .ProjectTo<CustomerListResponseDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}