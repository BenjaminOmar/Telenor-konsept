using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.DTOs.Business;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BusinessRepository(DataContext context, IMapper _mapper) : BaseRepository<Business>(context), IBusinessRepository
{
    private readonly DataContext _context = context;
    private readonly IQueryable<Business> _businessesQuery = context.Businesses.Where(b => !b.IsDeleted);

    public async Task<List<BusinessListResultDto>> GetBusinessList()
    {
        return await _businessesQuery
            .OrderBy(c => c.CreatedOn)
            .ProjectTo<BusinessListResultDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}