using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Contact;

public class CreateContactRequestDto
{
    public string Name { get; set; } = null!;
    
    [EmailAddress]
    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? Position { get; set; }
    
    public Guid CustomerId { get; set; }
}