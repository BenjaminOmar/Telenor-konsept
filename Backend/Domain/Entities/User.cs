using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;

public class User : BaseEntity
{
    [StringLength(100, MinimumLength = 5)]
    public string UserName { get; set; } = null!;

    public Address Address { get; set; } = null!;
} 