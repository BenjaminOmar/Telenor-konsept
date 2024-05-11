namespace Presentation.DTOs.Authentication;

public record RegisterRequestDto
{
    public string Username { get; set; } = null!;
    
    public string Name { get; set; } = null!;
    
    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string Password { get; set; } = null!;
    
    public Guid RoleId { get; set; }

    

}