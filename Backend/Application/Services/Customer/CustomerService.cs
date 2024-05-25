using AutoMapper;
using Domain.DTOs.Customer;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Customer;

namespace Application.Services.Customer;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IStatusRepository _statusRepository;
    private readonly IMapper _mapper;
    public CustomerService(ICustomerRepository customerRepository, IStatusRepository statusRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _statusRepository = statusRepository;
        _mapper = mapper;
    }
    
    public async Task<Result<List<CustomerListResponseDto>>> GetCustomerList()
    {
        var customerList = await _customerRepository.GetCustomerList();

        return Result<List<CustomerListResponseDto>>.Success(customerList);
    }

    
    public async Task<Result<CreateCustomerResponseDto>> CreateCustomer(CreateCustomerRequestDto createCustomerRequestDto)
    {
        if (await CheckCustomerNameUnique(createCustomerRequestDto.Name))
        {
            return Result<CreateCustomerResponseDto>.Failure("Bedriften er allerede registrert", 409);
        }
        
        if (!await StatusExists(createCustomerRequestDto.StatusId))
        {
            return Result<CreateCustomerResponseDto>.Failure("Valgt status finnes ikke i vårt system", 404);
        }
        
        var newCustomer =  new Domain.Entities.Customer()
        {
            Id = Guid.NewGuid(),
            Name = createCustomerRequestDto.Name,
            IsPrivateCustomer = createCustomerRequestDto.IsPrivateCustomer,
            OrganizationNr = createCustomerRequestDto.OrganizationNr,
            Address = createCustomerRequestDto.Address,
            PostCode = createCustomerRequestDto.PostCode,
            County = createCustomerRequestDto.County,
            Email = createCustomerRequestDto.Email,
            PhoneNumber = createCustomerRequestDto.PhoneNumber,
            BusinessId = new Guid(), // GET THE BUSINESSID OF THE USER
            StatusId = createCustomerRequestDto.StatusId,
            // ADD CREATEDBY AND THE OTHERS
        };
        await _customerRepository.Add(newCustomer);
        
        var responseDto = _mapper.Map<CreateCustomerResponseDto>(newCustomer);
        return Result<CreateCustomerResponseDto>.Success(responseDto);
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