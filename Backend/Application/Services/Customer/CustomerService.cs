using Domain.DTOs.Customer;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Customer;

namespace Application.Services.Customer;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IStatusRepository _statusRepository;
    public CustomerService(ICustomerRepository customerRepository, IStatusRepository statusRepository)
    {
        _customerRepository = customerRepository;
        _statusRepository = statusRepository;
    }
    
    public async Task<Result<List<CustomerListResponseDto>>> GetCustomerList()
    {
        var customerList = await _customerRepository.GetCustomerList();

        return Result<List<CustomerListResponseDto>>.Success(customerList);
    }

    
    public async Task<Result<CreateCustomerResponseDto>> CreateCustomer(CreateCustomerRequestDto createCustomerRequestDto)
    {
        if (!await CheckCustomerNameUnique(createCustomerRequestDto.Name))
        {
            return Result<CreateCustomerResponseDto>.Failure("Bedriften er allerede registrert", 409);
        }
        
        if (!await StatusExists(createCustomerRequestDto.StatusId))
        {
            return Result<CreateCustomerResponseDto>.Failure("Valgt status finnes ikke i vårt system", 404);
        }
        
        return Result<CreateCustomerResponseDto>.Success(new CreateCustomerResponseDto());
    }

    private async Task<bool> StatusExists(Guid statusId)
    {
        var status = await _statusRepository.GetById(statusId);
        return status != null;
    }

    private async Task<bool> CheckCustomerNameUnique(string customerName)
    {
        return await _customerRepository.CheckCustomerNameExists(customerName);
    }

}