using AutoMapper;
using Domain.DTOs.Customer;

namespace Application.Mapping.Customer;

public class CustomerMappingProfile : Profile
{
    public CustomerMappingProfile()
    {
        CreateMap<Domain.Entities.Customer, CreateCustomerResponseDto>();
    }
}