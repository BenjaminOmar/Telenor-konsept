using AutoMapper;
using Domain.DTOs.Contact;
using Domain.Entities;

namespace Infrastructure.Repositories.Mapping.Profiles;

public class ContactProfile : Profile
{
    public ContactProfile()
    {
        CreateMap<Contact, ContactListResponseDto>()
            .ForMember(c => c.ContactId, c => c.MapFrom(i => i.Id));
    }
}