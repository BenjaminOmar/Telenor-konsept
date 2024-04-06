using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Models;

public class User : IdentityUser
{
    [StringLength(100, MinimumLength = 5)]
    public string Fullname { get; set; } = null!;
}