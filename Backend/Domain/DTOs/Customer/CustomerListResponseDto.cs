namespace Domain.DTOs.Customer;

public class CustomerListResponseDto
{
    public Guid CustomerId { get; set; }
    
    public int CustomerNumber { get; set; }
    
    public string Name { get; set; } = null!;

    public bool IsPrivateCustomer { get; set; }
    
    public int OrganizationNr { get; set; }
    
    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }
}