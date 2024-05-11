using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_customer_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrivateCustomer = table.Column<bool>(type: "bit", nullable: false),
                    OrganizationNr = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                });

            migrationBuilder.UpdateData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 11, 21, 27, 12, 156, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode" },
                values: new object[] { new Guid("04ae4661-009e-47c3-a96f-e8b8ed15b39a"), "Daniels hus", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 11, 21, 27, 12, 157, DateTimeKind.Utc).AddTicks(2140), "Daniel@gmail.com", false, true, null, null, "Daniel Holtet", 123456789, "12345678", 0 });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 11, 21, 27, 12, 157, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 11, 21, 27, 12, 157, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_BusinessId",
                table: "Customer",
                column: "BusinessId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.UpdateData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("2d718eaa-7518-4c5b-8fe0-241bd2b69b0c"), new DateTime(2024, 5, 10, 18, 50, 28, 756, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("2d718eaa-7518-4c5b-8fe0-241bd2b69b0c"), new DateTime(2024, 5, 10, 18, 50, 28, 756, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("2d718eaa-7518-4c5b-8fe0-241bd2b69b0c"), new DateTime(2024, 5, 10, 18, 50, 28, 756, DateTimeKind.Utc).AddTicks(4510) });
        }
    }
}
