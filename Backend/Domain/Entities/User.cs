using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;

public class User : BaseEntity
{
    public User(string userName,
    Address address,
    string fullName,
    string password,
    string? phoneNumber)
    {
        UserName = userName;
        Address = address;
        FullName = fullName;
        Password = password;
        PhoneNumber = phoneNumber;
    }

    [StringLength(100, MinimumLength = 5)]
    public string UserName { get; set; } = null!;

    public string FullName { get; set; } = null!;

    [StringLength(100, MinimumLength = 8)]
    public string Password { get; set; } = null!;

    [StringLength(100, MinimumLength = 1)]
    public Address Address { get; set; } = null!;

    [StringLength(6, MinimumLength = 8)]
    public string? PhoneNumber { get; set; }
}