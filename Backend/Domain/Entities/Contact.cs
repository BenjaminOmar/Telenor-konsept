using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Contact : BaseEntity
{
    public string Name { get; set; } = null!;
    
    public string? PhoneNumber { get; set; }
    
    [EmailAddress]
    public string? Email { get; set; }
    
    public string? Position { get; set; }
    
    public Guid CustomerId { get; set; }
    
    public Customer Customer { get; set; } = null!;
}