using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_proper_customer_example_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[,]
                {
                    { new Guid("04ab9f8b-6051-458d-8b51-90d6bf6eb5dc"), "Forusbeen 50", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Stavanger", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9530), "contact@equinor.com", false, false, null, null, "Equinor", 923609016, "51990000", 4035, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("24a15855-30bd-4081-97c2-5217bd1c6779"), "Schweigaards gate 21", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9560), "contact@gjensidige.no", false, false, null, null, "Gjensidige", 995568217, "91503100", 191, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("381d800f-f5f7-4dae-923a-8e34ec7e8c68"), "Drammensveien 131", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9540), "contact@yara.com", false, false, null, null, "Yara International", 919937882, "24155000", 277, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("415957e0-a9a5-4ad0-b053-a09f4c2a65fd"), "Hammersborggata 2", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9570), "contact@sparebank1.no", false, false, null, null, "SpareBank 1", 947032579, "91504800", 106, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("426a4a81-5a81-4723-8626-b811e2e2d76b"), "Drammensveien 260", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9530), "contact@hydro.com", false, false, null, null, "Norsk Hydro", 914778271, "22532000", 283, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("572e6272-3445-4ec8-a9c5-82cf01cbad72"), "Hamar", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Hedmark", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9570), "contact@norsk-tipping.no", false, false, null, null, "Norsk Tipping", 982480105, "62508750", 2325, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("7d5496e4-86c0-400c-b224-cc1c0ae4048c"), "Snarøyveien 30", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Fornebu", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9520), "contact@telenor.com", false, false, null, null, "Telenor", 911066905, "67800000", 1360, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("d23e16e3-3a49-4330-a188-7ae7aca6cae3"), "Skøyen", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9550), "contact@orkla.no", false, false, null, null, "Orkla", 910747711, "22542000", 277, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("da1a7389-23d1-40b2-887b-f76f6aff232b"), "Dronning Eufemias gate 30", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9540), "contact@dnb.no", false, false, null, null, "DNB", 984851006, "91504800", 191, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("efb6e5e4-c6f9-4427-9ae5-33204e807874"), "Lakkegata 23", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(9560), "contact@tine.no", false, false, null, null, "Tine", 874560982, "03080", 187, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") }
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(8590));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("04ab9f8b-6051-458d-8b51-90d6bf6eb5dc"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("24a15855-30bd-4081-97c2-5217bd1c6779"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("381d800f-f5f7-4dae-923a-8e34ec7e8c68"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("415957e0-a9a5-4ad0-b053-a09f4c2a65fd"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("426a4a81-5a81-4723-8626-b811e2e2d76b"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("572e6272-3445-4ec8-a9c5-82cf01cbad72"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("7d5496e4-86c0-400c-b224-cc1c0ae4048c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("d23e16e3-3a49-4330-a188-7ae7aca6cae3"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("da1a7389-23d1-40b2-887b-f76f6aff232b"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("efb6e5e4-c6f9-4427-9ae5-33204e807874"));

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
    }
}
