using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Business> Businesses { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Status> Statuses { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Business>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BusinessId");
            entity.Property(e => e.Id).HasColumnName("BusinessId");
            entity.ToTable("Business");
            
            entity.HasData(
                new Business 
                { Id = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), 
                    Name = "Telenor", 
                    Address = "Snarøyveien 30",
                    PostCode = 1360,
                    County = "Fornebu",
                    Email = "noreply@telenor.com",
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464") ,
                    CreatedOn = DateTime.UtcNow
                }
            );
        });
        
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserId");
            entity.Property(e => e.Id).HasColumnName("UserId");
            entity.ToTable("User");
            entity.HasIndex(u => u.Username).IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("RoleId").IsRequired();
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
                        CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                        CreatedOn = DateTime.UtcNow
                    },
                new Role 
                    { Id = Guid.Parse("dd5a13da-11e4-4554-a697-76a4102fd72e"), 
                        Name = "Admin",
                        CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                        CreatedOn = DateTime.UtcNow
                    }
            );
        });
        
        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StatusId");
            entity.Property(e => e.Id).HasColumnName("StatusId");
            entity.ToTable("Status");

            entity.HasData(
                new Status
                    {
                        Id = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                        Name = "Lead",
                        CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                        CreatedOn = DateTime.UtcNow
                    },
                new Status
                {
                    Id = Guid.Parse("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                    Name = "Tatt Kontakt",
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow
                },
                new Status
                {
                    Id = Guid.Parse("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                    Name = "I Prosess",
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow
                },
                new Status
                {
                    Id = Guid.Parse("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                    Name = "Kunde",
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow
                },
                new Status
                {
                    Id = Guid.Parse("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                    Name = "Avslått",
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow
                });
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CustomerId");
            entity.Property(e => e.Id).HasColumnName("CustomerId");
            entity.ToTable("Customer");
            entity.Property(e => e.CustomerNumber).UseIdentityColumn();
            entity.HasIndex(e => e.Name).IsUnique();
            entity.HasIndex(e => e.OrganizationNr).IsUnique();

            entity.HasData(
                new Customer
                {
                    Id = Guid.Parse("04ae4661-009e-47c3-a96f-e8b8ed15b39a"),
                    Name = "Daniel Holtet",
                    IsPrivateCustomer = true,
                    OrganizationNr = 123456789,
                    Address = "Daniels hus",
                    PostCode = 0000,
                    County = "Oslo",
                    Email = "Daniel@gmail.com",
                    PhoneNumber = "12345678",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464") ,
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                    IsPrivateCustomer = false,
                    OrganizationNr = 135734567,
                    Address = "Benjamins hus",
                    PostCode = 0000,
                    County = "Tønsberg",
                    Email = "Benjamin@gmail.com",
                    PhoneNumber = "12345578",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464") ,
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                });
        });
    }
}