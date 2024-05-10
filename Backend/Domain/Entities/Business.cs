using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Business : BaseEntity
{
    public string Name { get; set; } = null!;

    public Address Address { get; set; } = null!;

    public EmailAddressAttribute Email { get; set; } = null!;
}