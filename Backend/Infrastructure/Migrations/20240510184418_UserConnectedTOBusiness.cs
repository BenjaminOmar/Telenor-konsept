using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserConnectedTOBusiness : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_User_BusinessId",
                table: "User",
                column: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Business_BusinessId",
                table: "User",
                column: "BusinessId",
                principalTable: "Business",
                principalColumn: "BusinessId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Business_BusinessId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_BusinessId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "User");

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
    }
}
