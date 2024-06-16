using Domain.DTOs.Contact;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Domain.Interfaces.Repositories;

public interface IContactRepository : IBaseRepository<Contact>
{
    Task<List<ContactListResponseDto>> GetContactList(Guid customerId);
}