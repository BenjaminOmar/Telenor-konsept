namespace Domain.DTOs.Customer;

public class CreateCustomerRequestDto
{
    public string Name { get; set; } = null!;

    public bool IsPrivateCustomer { get; set; }
    
    public int? OrganizationNr { get; set; }

    public string Address { get; set; } = null!;
    
    public int PostCode { get; set; }

    public string County { get; set; } = null!;
    
    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }
}