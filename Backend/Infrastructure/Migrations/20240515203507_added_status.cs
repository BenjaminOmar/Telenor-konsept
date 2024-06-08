using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessId", x => x.BusinessId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleId", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusId", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "UserServices",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserId", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsPrivateCustomer = table.Column<bool>(type: "bit", nullable: false),
                    OrganizationNr = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerId", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Business",
                columns: new[] { "BusinessId", "Address", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "PostCode" },
                values: new object[] { new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Snarøyveien 30", "Fornebu", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(4880), "noreply@telenor.com", false, null, null, "Telenor", 1360 });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("ccafb929-aa82-4981-96f9-53864b688c89"), new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6140), false, null, null, "UserServices" },
                    { new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"), new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6140), false, null, null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "CreatedBy", "CreatedOn", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"), new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6370), false, null, null, "Tatt Kontakt" },
                    { new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"), new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6370), false, null, null, "I Prosess" },
                    { new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"), new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6380), false, null, null, "Avslått" },
                    { new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"), new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6370), false, null, null, "Lead" },
                    { new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"), new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6380), false, null, null, "Kunde" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[,]
                {
                    { new Guid("04ae4661-009e-47c3-a96f-e8b8ed15b39a"), "Daniels hus", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(7460), "Daniel@gmail.com", false, true, null, null, "Daniel Holtet", 123456789, "12345678", 0, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("0d207162-26ee-4001-a54c-9178ade4f002"), "Benjamins hus", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Tønsberg", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(7480), "Benjamin@gmail.com", false, false, null, null, "Test", 135734567, "12345578", 0, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_BusinessId",
                table: "Customer",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Name",
                table: "Customer",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrganizationNr",
                table: "Customer",
                column: "OrganizationNr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_StatusId",
                table: "Customer",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Name",
                table: "Role",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_BusinessId",
                table: "UserServices",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "UserServices",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "UserServices",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "UserServices");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
