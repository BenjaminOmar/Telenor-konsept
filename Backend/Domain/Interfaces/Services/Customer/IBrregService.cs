using Domain.DTOs.Customer;
using Domain.Helpers;

namespace Domain.Interfaces.Services.Customer;

public interface IBrregService
{
    Task<Result<List<BrregResponseDto>>> GetBrregInfo(string? name, string? organizationNumber);
}