using AutoMapper;
using Domain.DTOs.Customer;
using Domain.DTOs.Status;
using Domain.Entities;

namespace Application.Mapping.Customer;

public class CustomerMappingProfile : Profile
{
    public CustomerMappingProfile()
    {
        CreateMap<Domain.Entities.Customer, CreateCustomerResponseDto>();

        CreateMap<Status, StatusListResponseDto>()
            .ForMember(dest => dest.StatusId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        
        CreateMap<ICollection<Status>, CustomerOptionsResponseDto>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src));
        
        CreateMap<List<Status>, CustomerOptionsResponseDto>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src));
    }
}