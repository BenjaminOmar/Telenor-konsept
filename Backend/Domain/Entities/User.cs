using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Domain.ValueObjects;

namespace Domain.Entities;

public class User : BaseEntity
{
    [StringLength(100, MinimumLength = 5)]
    public string Username { get; set; }

    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }

    [StringLength(150, MinimumLength = 8)]
    public string Password { get; set; }

    [StringLength(30, MinimumLength = 8)]
    public string? PhoneNumber { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
}