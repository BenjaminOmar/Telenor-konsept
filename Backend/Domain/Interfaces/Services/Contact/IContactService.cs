using Domain.DTOs.Contact;
using Domain.Helpers;

namespace Domain.Interfaces.Services.Contact;

public interface IContactService
{
    Task<Result<List<ContactListResponseDto>>> GetContactList(Guid customerId);
    Task<Result<ContactResponseDto>> CreateContact(CreateContactRequestDto createContactRequestDto);
}