using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.DTOs.Status;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class StatusRepository (DataContext context, IMapper mapper) : BaseRepository<Status>(context), IStatusRepository
{
    private readonly DataContext _context = context;
    private readonly IMapper _mapper = mapper;

    public async Task<List<StatusListResponseDto>> GetStatusList()
    {
        IQueryable<Status> statusQuery = _context.Statuses;

        return await statusQuery
            .ProjectTo<StatusListResponseDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}