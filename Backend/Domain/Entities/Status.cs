namespace Domain.Entities;

public class Status : BaseEntity
{
    public string Name { get; set; } = null!;
    
    public ICollection<Customer> Customers { get; set; } = [];
}