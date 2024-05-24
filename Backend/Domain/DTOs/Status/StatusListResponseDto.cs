namespace Domain.DTOs.Status;

public class StatusListResponseDto
{
    public Guid StatusId { get; set; }
    public string Name { get; set; } = null!;
}