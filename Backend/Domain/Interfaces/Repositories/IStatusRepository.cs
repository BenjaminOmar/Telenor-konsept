using Domain.DTOs.Status;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Domain.Interfaces.Repositories;

public interface IStatusRepository : IBaseRepository<Status>
{
    Task<List<StatusListResponseDto>> GetStatusList();
}