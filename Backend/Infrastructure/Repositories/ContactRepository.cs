using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;

namespace Infrastructure.Repositories;

public class ContactRepository(DataContext context, IMapper _mapper) : BaseRepository<Contact>(context), IContactRepository
{
    private readonly DataContext _context = context;
    private readonly IMapper _mapper = _mapper;
    private readonly IQueryable<Contact> _contactsQuery = context.Contacts.Where(c => !c.IsDeleted);

    public async Task<ContactsResponseDto> GetContactList(Guid customerId)
    {
        return await _contactsQuery
            .Where(c => c.CustomerId == customerId)
            .ProjectTo<ContactsResponseDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}