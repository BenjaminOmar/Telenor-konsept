using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_business : Migration
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

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 18, 34, 10, 651, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 18, 34, 10, 651, DateTimeKind.Utc).AddTicks(6030));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 19, 54, 49, 157, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 4, 17, 19, 54, 49, 157, DateTimeKind.Utc).AddTicks(8910));
        }
    }
}
