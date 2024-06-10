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
    private readonly IQueryable<Status> _statusQuery = context.Statuses.Where(s => !s.IsDeleted);

    public async Task<List<StatusListResponseDto>> GetStatusList()
    {
        return await _statusQuery
            .ProjectTo<StatusListResponseDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}