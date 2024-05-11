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

    public async Task<List<BusinessListResultDto>> GetBusinessList()
    {
        IQueryable<Business> businessQuery = _context.Businesses;
        
        return await businessQuery
            .ProjectTo<BusinessListResultDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}