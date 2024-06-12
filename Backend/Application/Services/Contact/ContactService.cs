using Domain.DTOs.Contact;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Contact;

namespace Application.Services.Contact;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;
    
    public ContactService(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }
    
    public async Task<Result<List<ContactListResponseDto>>> GetContactList(Guid customerId)
    {
        var result = await _contactRepository.GetContactList(customerId);
        
        return Result<List<ContactListResponseDto>>.Success(result);
    }
}