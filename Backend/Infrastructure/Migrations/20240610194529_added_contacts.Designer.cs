﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240610194529_added_contacts")]
    partial class added_contacts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Business", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("BusinessId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_BusinessId");

                    b.ToTable("Business", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            Address = "Snarøyveien 30",
                            County = "Fornebu",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(1240),
                            Email = "noreply@telenor.com",
                            IsDeleted = false,
                            Name = "Telenor",
                            PostCode = 1360
                        });
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ContactId");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_ContactId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerNumber"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrivateCustomer")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("OrganizationNr")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("PK_CustomerId");

                    b.HasIndex("BusinessId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("StatusId");

                    b.ToTable("Customer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("58b65f15-b82c-4882-859f-10c21e9cc453"),
                            Address = "Snarøyveien 30",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Fornebu",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4270),
                            CustomerNumber = 0,
                            Email = "contact@telenor.com",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "Telenor",
                            OrganizationNr = 911066905,
                            PhoneNumber = "67800000",
                            PostCode = 1360,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("cd4937c1-a882-40fd-a9e1-7874bd20174c"),
                            Address = "Forusbeen 50",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Stavanger",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4280),
                            CustomerNumber = 0,
                            Email = "contact@equinor.com",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "Equinor",
                            OrganizationNr = 923609016,
                            PhoneNumber = "51990000",
                            PostCode = 4035,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("a5fa329e-b771-4715-a23e-7549147d2615"),
                            Address = "Drammensveien 260",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Oslo",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4290),
                            CustomerNumber = 0,
                            Email = "contact@hydro.com",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "Norsk Hydro",
                            OrganizationNr = 914778271,
                            PhoneNumber = "22532000",
                            PostCode = 283,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("d32c0e33-2650-4459-9364-ab3138080e90"),
                            Address = "Drammensveien 131",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Oslo",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4290),
                            CustomerNumber = 0,
                            Email = "contact@yara.com",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "Yara International",
                            OrganizationNr = 919937882,
                            PhoneNumber = "24155000",
                            PostCode = 277,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("8a2cd4be-a9cf-4ea4-88ab-7e8efc0daa8a"),
                            Address = "Dronning Eufemias gate 30",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Oslo",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4300),
                            CustomerNumber = 0,
                            Email = "contact@dnb.no",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "DNB",
                            OrganizationNr = 984851006,
                            PhoneNumber = "91504800",
                            PostCode = 191,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("41054c80-9eb1-4c0f-90f6-977c6deafa8a"),
                            Address = "Skøyen",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Oslo",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4310),
                            CustomerNumber = 0,
                            Email = "contact@orkla.no",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "Orkla",
                            OrganizationNr = 910747711,
                            PhoneNumber = "22542000",
                            PostCode = 277,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("a2f801d2-2ea9-44a2-b816-c649f8108584"),
                            Address = "Lakkegata 23",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Oslo",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4330),
                            CustomerNumber = 0,
                            Email = "contact@tine.no",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "Tine",
                            OrganizationNr = 874560982,
                            PhoneNumber = "03080",
                            PostCode = 187,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("ae173435-f7df-44cb-9d4c-0a344819437a"),
                            Address = "Schweigaards gate 21",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Oslo",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4340),
                            CustomerNumber = 0,
                            Email = "contact@gjensidige.no",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "Gjensidige",
                            OrganizationNr = 995568217,
                            PhoneNumber = "91503100",
                            PostCode = 191,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("1517ea94-0b62-4906-bfd0-8bedae30baff"),
                            Address = "Hamar",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Hedmark",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4340),
                            CustomerNumber = 0,
                            Email = "contact@norsk-tipping.no",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "Norsk Tipping",
                            OrganizationNr = 982480105,
                            PhoneNumber = "62508750",
                            PostCode = 2325,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        },
                        new
                        {
                            Id = new Guid("f080d2cb-6fbd-4785-9d46-740cb33d30f7"),
                            Address = "Hammersborggata 2",
                            BusinessId = new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                            County = "Oslo",
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4350),
                            CustomerNumber = 0,
                            Email = "contact@sparebank1.no",
                            IsDeleted = false,
                            IsPrivateCustomer = false,
                            Name = "SpareBank 1",
                            OrganizationNr = 947032579,
                            PhoneNumber = "91504800",
                            PostCode = 106,
                            StatusId = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RoleId");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .HasName("PK_RoleId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2590),
                            IsDeleted = false,
                            Name = "User"
                        },
                        new
                        {
                            Id = new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2590),
                            IsDeleted = false,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StatusId");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_StatusId");

                    b.ToTable("Status", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2850),
                            IsDeleted = false,
                            Name = "Lead"
                        },
                        new
                        {
                            Id = new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2850),
                            IsDeleted = false,
                            Name = "Tatt Kontakt"
                        },
                        new
                        {
                            Id = new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2860),
                            IsDeleted = false,
                            Name = "I Prosess"
                        },
                        new
                        {
                            Id = new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2860),
                            IsDeleted = false,
                            Name = "Kunde"
                        },
                        new
                        {
                            Id = new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                            CreatedBy = new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"),
                            CreatedOn = new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2860),
                            IsDeleted = false,
                            Name = "Avslått"
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.Property<Guid>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RoleId");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_UserId");

                    b.HasIndex("BusinessId");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany("Contacts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.HasOne("Domain.Entities.Business", "Business")
                        .WithMany("Customers")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Status", "Status")
                        .WithMany("Customers")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Business", "Business")
                        .WithMany("Users")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Entities.Business", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.Status", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
