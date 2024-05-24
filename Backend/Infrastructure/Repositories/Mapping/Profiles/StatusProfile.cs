using AutoMapper;
using Domain.DTOs.Status;
using Domain.Entities;

namespace Infrastructure.Repositories.Mapping.Profiles;

public class StatusProfile : Profile
{
    public StatusProfile()
    {
        CreateMap<Status, StatusListResponseDto>()
            .ForMember(d => d.StatusId, s => s.MapFrom(s =>  s.Id));
    }
}