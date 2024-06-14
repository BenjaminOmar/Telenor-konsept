using Application.Mapping.Customer;
using AutoMapper;
using Domain.DTOs.Contact;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Contact;
using Domain.Interfaces.Services.User;

namespace Application.Services.Contact;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUser;
    private readonly ICustomerRepository _customerRepository;
    
    public ContactService(IContactRepository contactRepository, 
        IMapper mapper, 
        ICurrentUserService currentUser,
        ICustomerRepository customerRepository)
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
        _currentUser = currentUser;
        _customerRepository = customerRepository;
    }
    
    public async Task<Result<List<ContactListResponseDto>>> GetContactList(Guid customerId)
    {
        var result = await _contactRepository.GetContactList(customerId);
        
        return Result<List<ContactListResponseDto>>.Success(result);
    }

    public async Task<Result<ContactResponseDto>> CreateContact(CreateContactRequestDto createContactRequestDto)
    {
        if (await CheckCustomerIsValid(createContactRequestDto.CustomerId) == false)
        {
            return Result<ContactResponseDto>.Failure("Kunden finnes ikke");
        }
        
        var newContact = _mapper.Map<Domain.Entities.Contact>(createContactRequestDto);
        await _contactRepository.Add(newContact);
        return Result<ContactResponseDto>.Success(_mapper.Map<ContactResponseDto>(newContact));
    }

    private async Task<bool> CheckCustomerIsValid(Guid customerId)
    {
        var customer = await _customerRepository.GetById(customerId);

        return customer is not null && customer.BusinessId == _currentUser.BusinessId;
    }
    
    
}