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
    
    public DbSet<Contact> Contacts { get; set; }


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
        
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ContactId");
            entity.Property(e => e.Id).HasColumnName("ContactId");
            entity.ToTable("Contact");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CustomerId");
            entity.Property(e => e.Id).HasColumnName("CustomerId");
            entity.ToTable("Customer");
            entity.Property(e => e.CustomerNumber).UseIdentityColumn();
            entity.HasIndex(e => e.Name).IsUnique();

            entity.HasData(
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Telenor",
                    IsPrivateCustomer = false,
                    OrganizationNr = 911066905,
                    Address = "Snarøyveien 30",
                    PostCode = 1360,
                    County = "Fornebu",
                    Email = "contact@telenor.com",
                    PhoneNumber = "67800000",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Equinor",
                    IsPrivateCustomer = false,
                    OrganizationNr = 923609016,
                    Address = "Forusbeen 50",
                    PostCode = 4035,
                    County = "Stavanger",
                    Email = "contact@equinor.com",
                    PhoneNumber = "51990000",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Norsk Hydro",
                    IsPrivateCustomer = false,
                    OrganizationNr = 914778271,
                    Address = "Drammensveien 260",
                    PostCode = 0283,
                    County = "Oslo",
                    Email = "contact@hydro.com",
                    PhoneNumber = "22532000",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Yara International",
                    IsPrivateCustomer = false,
                    OrganizationNr = 919937882,
                    Address = "Drammensveien 131",
                    PostCode = 0277,
                    County = "Oslo",
                    Email = "contact@yara.com",
                    PhoneNumber = "24155000",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "DNB",
                    IsPrivateCustomer = false,
                    OrganizationNr = 984851006,
                    Address = "Dronning Eufemias gate 30",
                    PostCode = 0191,
                    County = "Oslo",
                    Email = "contact@dnb.no",
                    PhoneNumber = "91504800",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Orkla",
                    IsPrivateCustomer = false,
                    OrganizationNr = 910747711,
                    Address = "Skøyen",
                    PostCode = 0277,
                    County = "Oslo",
                    Email = "contact@orkla.no",
                    PhoneNumber = "22542000",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Tine",
                    IsPrivateCustomer = false,
                    OrganizationNr = 874560982,
                    Address = "Lakkegata 23",
                    PostCode = 0187,
                    County = "Oslo",
                    Email = "contact@tine.no",
                    PhoneNumber = "03080",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Gjensidige",
                    IsPrivateCustomer = false,
                    OrganizationNr = 995568217,
                    Address = "Schweigaards gate 21",
                    PostCode = 0191,
                    County = "Oslo",
                    Email = "contact@gjensidige.no",
                    PhoneNumber = "91503100",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Norsk Tipping",
                    IsPrivateCustomer = false,
                    OrganizationNr = 982480105,
                    Address = "Hamar",
                    PostCode = 2325,
                    County = "Hedmark",
                    Email = "contact@norsk-tipping.no",
                    PhoneNumber = "62508750",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "SpareBank 1",
                    IsPrivateCustomer = false,
                    OrganizationNr = 947032579,
                    Address = "Hammersborggata 2",
                    PostCode = 0106,
                    County = "Oslo",
                    Email = "contact@sparebank1.no",
                    PhoneNumber = "91504800",
                    BusinessId = Guid.Parse("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                    CreatedBy = Guid.Parse("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                    CreatedOn = DateTime.UtcNow,
                    StatusId = Guid.Parse("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                });
        });
    }
}