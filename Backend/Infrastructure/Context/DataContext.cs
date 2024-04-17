using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserId");
            entity.Property(e => e.Id).HasColumnName("UserId");
            entity.ToTable("User");
            entity.HasIndex(u => u.Username).IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("RoleId").IsRequired();
            entity.HasOne(u => u.Role)
                  .WithMany(r => r.Users)
                  .HasForeignKey(u => u.RoleId);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RoleId");
            entity.Property(e => e.Id).HasColumnName("RoleId");
            entity.ToTable("Role");
            entity.HasIndex(r => r.Name).IsUnique();
            
            entity.HasData(
                new Role 
                    { Id = Guid.Parse("ccafb929-aa82-4981-96f9-53864b688c89"), 
                        Name = "User", 
                        CreatedBy = Guid.Parse("2d718eaa-7518-4c5b-8fe0-241bd2b69b0c") ,
                        CreatedOn = DateTime.UtcNow
                    },
                new Role 
                    { Id = Guid.Parse("dd5a13da-11e4-4554-a697-76a4102fd72e"), 
                        Name = "Admin",
                        CreatedBy = Guid.Parse("2d718eaa-7518-4c5b-8fe0-241bd2b69b0c") ,
                        CreatedOn = DateTime.UtcNow
                    }
            );
        });
    }
}