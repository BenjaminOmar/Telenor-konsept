using Domain.DTOs.Business;
using Domain.Helpers;

namespace Application.Services.Business;

public interface IBusinessService
{
    Task<Result<List<BusinessListResultDto>>> GetBusinessList();
}