using Domain.DTOs.Status;
using Domain.Helpers;

namespace Domain.Interfaces.Services.Status;

public interface IStatusService
{
    Task<Result<List<StatusListResponseDto>>> GetStatusList();
}