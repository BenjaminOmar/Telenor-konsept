using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_customer_dummy_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("04ae4661-009e-47c3-a96f-e8b8ed15b39a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("45d471de-7122-4dcd-90f7-2246af8125e1"));

            migrationBuilder.UpdateData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 8, 59, 828, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[,]
                {
                    { new Guid("6ad01e61-e9a9-48a6-8e40-1c0efd1cca77"), "Eve's condo", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Kristiansand", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1380), "eve@gmail.com", false, true, null, null, "Eve White", 654321987, "67890123", 5005, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("74a7e7b6-634c-4cfa-a2cc-f7dc5d3a47eb"), "Grace's home", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Haugesund", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1390), "grace@gmail.com", false, true, null, null, "Grace Miller", 654987321, "89012345", 7007, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("88e410c2-0148-48e6-9d6f-27ba0a0b6318"), "Henry's flat", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Ålesund", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1400), "henry@gmail.com", false, false, null, null, "Henry Wilson", 321654987, "90123456", 8008, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("91c43403-f90a-423d-b508-fa0ede2397bb"), "Alice's house", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Bergen", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1360), "alice@gmail.com", false, true, null, null, "Alice Johnson", 123987654, "23456789", 1001, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("9881dc3b-f414-4a8b-8bf0-2b7e2aff2f74"), "David's villa", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Drammen", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1380), "david@gmail.com", false, false, null, null, "David Brown", 321789654, "56789012", 4004, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("9cf584ee-0bc8-493b-b4fa-f6189c30a1b7"), "Ivy's residence", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Tromsø", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1410), "ivy@gmail.com", false, true, null, null, "Ivy Harris", 789321456, "01234567", 9009, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("cb71484e-cb49-41db-922f-f6c7ec40d720"), "Catherine's apartment", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Stavanger", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1370), "catherine@gmail.com", false, true, null, null, "Catherine Lee", 789654321, "45678901", 3003, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("d9660db3-44ee-4cfd-876f-bce41793daa6"), "Bob's residence", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Trondheim", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1360), "bob@gmail.com", false, false, null, null, "Bob Smith", 456123789, "34567890", 2002, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("e67b406b-9ffb-4ece-87bd-4448c8d90228"), "Frank's house", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Bodø", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(1390), "frank@gmail.com", false, false, null, null, "Frank Green", 987123654, "78901234", 6006, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") }
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 8, 59, 829, DateTimeKind.Utc).AddTicks(350));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("6ad01e61-e9a9-48a6-8e40-1c0efd1cca77"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("74a7e7b6-634c-4cfa-a2cc-f7dc5d3a47eb"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("88e410c2-0148-48e6-9d6f-27ba0a0b6318"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("91c43403-f90a-423d-b508-fa0ede2397bb"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("9881dc3b-f414-4a8b-8bf0-2b7e2aff2f74"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("9cf584ee-0bc8-493b-b4fa-f6189c30a1b7"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("cb71484e-cb49-41db-922f-f6c7ec40d720"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("d9660db3-44ee-4cfd-876f-bce41793daa6"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("e67b406b-9ffb-4ece-87bd-4448c8d90228"));

            migrationBuilder.UpdateData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 23, 17, 5, 17, 269, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[,]
                {
                    { new Guid("04ae4661-009e-47c3-a96f-e8b8ed15b39a"), "Daniels hus", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(2220), "Daniel@gmail.com", false, true, null, null, "Daniel Holtet", 123456789, "12345678", 0, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("45d471de-7122-4dcd-90f7-2246af8125e1"), "Benjamins hus", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Tønsberg", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 23, 17, 5, 17, 270, DateTimeKind.Utc).AddTicks(2270), "Benjamin@gmail.com", false, false, null, null, "Test", 135734567, "12345578", 0, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") }
                });

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
    }
}
