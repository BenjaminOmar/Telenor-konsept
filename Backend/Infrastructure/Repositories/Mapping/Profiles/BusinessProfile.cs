using AutoMapper;
using Domain.DTOs.Business;
using Domain.Entities;

namespace Infrastructure.Repositories.Mapping.Profiles;

public class BusinessProfile : Profile
{
    public BusinessProfile()
    {
        CreateMap<Business, BusinessListResultDto>();
    }
}