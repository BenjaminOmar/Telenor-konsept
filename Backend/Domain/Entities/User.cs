using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Domain.ValueObjects;

namespace Domain.Entities;

public class User : BaseEntity
{
    public User(
        string username,
        string name,
        string password,
        Guid createdBy,
        string? phoneNumber,
        Guid? modifiedBy,
        DateTime? modifiedOn)
    {
        Id = new Guid();
        Username = username;
        Name = name;
        Password = password;
        PhoneNumber = phoneNumber;
        CreatedBy = createdBy;
        CreatedOn = DateTime.UtcNow;
        ModifiedBy = modifiedBy;
        ModifiedOn = modifiedOn;
    }

    [StringLength(100, MinimumLength = 5)]
    public string Username { get; set; }
    
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }

    [StringLength(100, MinimumLength = 8)]
    public string Password { get; set; }
    
    [StringLength(6, MinimumLength = 8)]
    public string? PhoneNumber { get; set; }
    
    [EmailAddress]
    public string? Email { get; set; }
}