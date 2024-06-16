using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Contact;

public class ContactListResponseDto
{
    public Guid ContactId { get; set; }
    
    public string Name { get; set; } = null!;
    
    [EmailAddress]
    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? Position { get; set; }
}