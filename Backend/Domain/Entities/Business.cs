using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Business : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;
    
    public int PostCode { get; set; }

    public string County { get; set; } = null!;

    public string Email { get; set; } = null!;
    
    public ICollection<User> Users { get; set; } = [];

    public ICollection<Customer> Customers { get; set; } = [];
}