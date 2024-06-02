namespace Domain.DTOs.Customer;

public class BrregResponseDto
{
    public string? Name { get; set; }
    public string? OrganizationNumber { get; set; }
    
    public BrregSerializerHelperDto.Forretningsadresse? Forretningsadresse { get; set; }
}

