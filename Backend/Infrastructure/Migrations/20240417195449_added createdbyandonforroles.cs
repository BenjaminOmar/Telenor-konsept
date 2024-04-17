using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedcreatedbyandonforroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("2d718eaa-7518-4c5b-8fe0-241bd2b69b0c"), new DateTime(2024, 4, 17, 19, 54, 49, 157, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("2d718eaa-7518-4c5b-8fe0-241bd2b69b0c"), new DateTime(2024, 4, 17, 19, 54, 49, 157, DateTimeKind.Utc).AddTicks(8910) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                columns: new[] { "CreatedBy", "CreatedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
