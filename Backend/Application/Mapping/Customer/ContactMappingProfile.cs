using AutoMapper;
using Domain.DTOs.Contact;
using Domain.Entities;

namespace Application.Mapping.Customer;

public class ContactMappingProfile : Profile
{
    public ContactMappingProfile()
    {
        CreateMap<CreateContactRequestDto, Contact>();
        
        CreateMap<Contact, ContactResponseDto>()
            .ForMember(d => d.ContactId, src => src.MapFrom(c => c.Id));
    }
}