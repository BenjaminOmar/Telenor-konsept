namespace Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    
    public Guid CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    
    public Guid ModifiedBy { get; set; }
    
    public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;
}