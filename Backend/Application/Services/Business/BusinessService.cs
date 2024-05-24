using Domain.DTOs.Business;
using Domain.Helpers;
using Domain.Interfaces.Repositories;

namespace Application.Services.Business;

public class BusinessService : IBusinessService
{
    private readonly IBusinessRepository _businessRepository;
    public BusinessService(IBusinessRepository businessRepository)
    {
        _businessRepository = businessRepository;
    }
    public async Task<Result<List<BusinessListResultDto>>> GetBusinessList()
    {
        var businesses = await _businessRepository.GetBusinessList();
        
        return Result<List<BusinessListResultDto>>.Success(businesses);
    }   
}