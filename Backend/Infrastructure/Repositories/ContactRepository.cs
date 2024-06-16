using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Domain.DTOs.Contact;

namespace Infrastructure.Repositories;

public class ContactRepository(DataContext context, IMapper mapper) : BaseRepository<Contact>(context), IContactRepository
{
    private readonly IQueryable<Contact> _contactsQuery = context.Contacts.Where(c => !c.IsDeleted);
    
    public async Task<List<ContactListResponseDto>> GetContactList(Guid customerId)
    {
        return await _contactsQuery
            .Where(c => c.CustomerId == customerId)
            .OrderBy(c => c.CreatedOn)
            .ProjectTo<ContactListResponseDto>(mapper.ConfigurationProvider)
            .ToListAsync();
    }
}