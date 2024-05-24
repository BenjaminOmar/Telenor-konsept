using Domain.DTOs.Business;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Domain.Interfaces.Repositories;

public interface IBusinessRepository : IBaseRepository<Business>
{
    Task<List<BusinessListResultDto>> GetBusinessList();
}