using Domain.DTOs.Customer;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Customer;

namespace Application.Services.Customer;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public async Task<Result<List<CustomerListResponseDto>>> GetCustomerList()
    {
        var customerList = await _customerRepository.GetCustomerList();

        return Result<List<CustomerListResponseDto>>.Success(customerList);
    }
    
}