namespace Contracts.Authentication
{
    public record RegisterRequest(
        string Username,
        string Name,
        string? Email,
        string? PhoneNumber,
        string Password,
        Guid RoleId);
}