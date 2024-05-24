using Domain.DTOs.Customer;
using Domain.Helpers;

namespace Domain.Interfaces.Services.Customer;

public interface ICustomerService
{
    Task<Result<List<CustomerListResponseDto>>> GetCustomerList();

    Task<Result<CreateCustomerResponseDto>> CreateCustomer(CreateCustomerRequestDto createCustomerRequestDto);
}