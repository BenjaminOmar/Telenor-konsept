using AutoMapper;
using Domain.Consts;
using Domain.DTOs.Customer;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Customer;
using Domain.Interfaces.Services.User;

namespace Application.Services.Customer;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IStatusRepository _statusRepository;
    private readonly ICurrentUserService _currentUserService;
    private readonly IMapper _mapper;
    public CustomerService(ICustomerRepository customerRepository, IStatusRepository statusRepository, ICurrentUserService currentUserService, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _statusRepository = statusRepository;
        _currentUserService = currentUserService;
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

        if (createCustomerRequestDto.OrganizationNr is not null)
        {
            if (await CheckOrganizationNrUnique(createCustomerRequestDto.OrganizationNr.Value))
            {
                return Result<CreateCustomerResponseDto>.Failure("Organisasjonsnummeret er allerede registrert", 409);
            }
        }
        
        var currentUser = await _currentUserService.GetUser();

        if (currentUser is null)
        {
            return Result<CreateCustomerResponseDto>.Failure("Kan ikke finne din bruker i systemet", 401);
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
            BusinessId = currentUser.BusinessId,
            StatusId = StatusConsts.LEAD_STATUS_ID,
            CreatedBy = currentUser.Id,
            CreatedOn = DateTime.UtcNow
        };
        await _customerRepository.Add(newCustomer);
        
        var responseDto = _mapper.Map<CreateCustomerResponseDto>(newCustomer);
        return Result<CreateCustomerResponseDto>.Success(responseDto);
    }

    public async Task<Result<CustomerOptionsResponseDto>> GetCustomerOptions()
    {
        var statuses = _mapper.Map<CustomerOptionsResponseDto>(await _statusRepository.GetAll());
        return Result<CustomerOptionsResponseDto>.Success(statuses);
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

    private async Task<bool> CheckOrganizationNrUnique(int organizationNr)
    {
        return await _customerRepository.CheckOrgNrExists(organizationNr);
    }

}