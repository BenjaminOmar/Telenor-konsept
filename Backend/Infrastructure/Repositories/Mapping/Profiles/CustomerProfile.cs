using AutoMapper;
using Domain.DTOs.Customer;
using Domain.Entities;

namespace Infrastructure.Repositories.Mapping.Profiles;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerListResponseDto>()
            .ForMember(c => c.CustomerId, c => c.MapFrom(i => i.Id))
            .ForMember(c => c.Status, c => c.MapFrom(s => s.Status.Name));
    }
}