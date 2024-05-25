using AutoMapper;
using Domain.DTOs.Customer;

namespace Application.Mapping.Customer;

public class CustomerMappingProfile : Profile
{
    public CustomerMappingProfile()
    {
        CreateMap<CreateCustomerRequestDto, Domain.Entities.Customer>();
    }
}