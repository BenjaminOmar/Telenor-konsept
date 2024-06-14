using AutoMapper;
using Domain.DTOs.Contact;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Contact;

namespace Application.Services.Contact;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;
    private readonly IMapper _mapper;
    
    public ContactService(IContactRepository contactRepository, IMapper mapper)
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
    }
    
    public async Task<Result<List<ContactListResponseDto>>> GetContactList(Guid customerId)
    {
        var result = await _contactRepository.GetContactList(customerId);
        
        return Result<List<ContactListResponseDto>>.Success(result);
    }

    public async Task<Result<ContactResponseDto>> CreateContact(CreateContactRequestDto createContactRequestDto)
    {
        // må sjekke om customerId finnes og om den tilhører samme business som brukeren
        
        var newContact = _mapper.Map<Domain.Entities.Contact>(createContactRequestDto);
        await _contactRepository.Add(newContact);
        return Result<ContactResponseDto>.Success(_mapper.Map<ContactResponseDto>(newContact));
    }
    
    
}