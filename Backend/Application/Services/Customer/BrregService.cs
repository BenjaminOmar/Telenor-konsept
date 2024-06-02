using Domain.DTOs.Customer;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Customer;

namespace Application.Services.Customer;

public class BrregService : IBrregService
{
    private readonly ICustomerRepository _customerRepository;
    
    public BrregService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public async Task<Result<List<BrregResponseDto>>> GetBrregInfo(string? name, string? organizationNumber)
    {
        var result = await _customerRepository.GetBrregCompanyInformation(name, organizationNumber);

        return Result<List<BrregResponseDto>>.Success(result);
    }
}