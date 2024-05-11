using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_data_to_business : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "Business",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PostCode",
                table: "Business",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Business",
                columns: new[] { "BusinessId", "Address", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "PostCode" },
                values: new object[] { new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Snarøyveien 30", "Fornebu", new Guid("2d718eaa-7518-4c5b-8fe0-241bd2b69b0c"), new DateTime(2024, 5, 10, 18, 50, 28, 756, DateTimeKind.Utc).AddTicks(2190), "noreply@telenor.com", false, null, null, "Telenor", 1360 });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 18, 50, 28, 756, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 18, 50, 28, 756, DateTimeKind.Utc).AddTicks(4510));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"));

            migrationBuilder.DropColumn(
                name: "County",
                table: "Business");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Business");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 18, 44, 18, 301, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 18, 44, 18, 301, DateTimeKind.Utc).AddTicks(9250));
        }
    }
}
