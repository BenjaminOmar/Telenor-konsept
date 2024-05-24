using Domain.DTOs.Status;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Status;

namespace Application.Services.Status;

public class StatusService(IStatusRepository statusRepository) : IStatusService
{
    public async Task<Result<List<StatusListResponseDto>>> GetStatusList()
    {
        var result = await statusRepository.GetStatusList();

        return Result<List<StatusListResponseDto>>.Success(result);
    }
}