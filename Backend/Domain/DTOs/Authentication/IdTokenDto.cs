namespace Domain.DTOs.Authentication;

public class IdTokenDto
{
    public string Name { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
}