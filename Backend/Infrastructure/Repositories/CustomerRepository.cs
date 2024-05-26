using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.DTOs.Customer;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.User;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CustomerRepository(DataContext context, IMapper mapper, ICurrentUserService currentUserService) : BaseRepository<Customer>(context), ICustomerRepository
{
    private readonly DataContext _context = context;
    private readonly IMapper _mapper = mapper;
    private readonly ICurrentUserService _currentUserService = currentUserService;

    public async Task<List<CustomerListResponseDto>> GetCustomerList()
    {
        IQueryable<Customer> customerQuery = _context.Customers;

        return await customerQuery
            .Where(c => c.BusinessId == _currentUserService.BusinessId)
            .OrderByDescending(c => c.CreatedOn)
            .ProjectTo<CustomerListResponseDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }

    public async Task<bool> CheckCustomerNameExists(string customerName)
    {
        IQueryable<Customer> customerQuery = _context.Customers;

        return await customerQuery
            .Where(c => c.BusinessId == _currentUserService.BusinessId)
            .AnyAsync(c => c.Name == customerName);

    }
    
    public async Task<bool> CheckOrgNrExists(int organizationNr)
    {
        IQueryable<Customer> customerQuery = _context.Customers;

        return await customerQuery
            .Where(c => c.BusinessId == _currentUserService.BusinessId)
            .AnyAsync(c => c.OrganizationNr == organizationNr);
    }
}