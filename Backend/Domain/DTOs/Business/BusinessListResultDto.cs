namespace Domain.DTOs.Business;

public class BusinessListResultDto
{
    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;
    
    public int PostCode { get; set; }

    public string County { get; set; } = null!;

    public string Email { get; set; } = null!;
}