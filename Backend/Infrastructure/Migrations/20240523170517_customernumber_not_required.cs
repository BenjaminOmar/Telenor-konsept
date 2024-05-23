using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class customernumber_not_required : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customer_OrganizationNr",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("0d207162-26ee-4001-a54c-9178ade4f002"));

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationNr",
                table: "Customer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 269, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("04ae4661-009e-47c3-a96f-e8b8ed15b39a"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[] { new Guid("45d471de-7122-4dcd-90f7-2246af8125e1"), "Benjamins hus", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Tønsberg", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(2270), "Benjamin@gmail.com", false, false, null, null, "Test", 135734567, "12345578", 0, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(1180));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("45d471de-7122-4dcd-90f7-2246af8125e1"));

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationNr",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("04ae4661-009e-47c3-a96f-e8b8ed15b39a"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[] { new Guid("0d207162-26ee-4001-a54c-9178ade4f002"), "Benjamins hus", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Tønsberg", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(7480), "Benjamin@gmail.com", false, false, null, null, "Test", 135734567, "12345578", 0, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 15, 20, 35, 6, 844, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrganizationNr",
                table: "Customer",
                column: "OrganizationNr",
                unique: true);
        }
    }
}
