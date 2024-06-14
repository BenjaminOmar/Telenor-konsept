using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_contact_endpoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("1517ea94-0b62-4906-bfd0-8bedae30baff"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("41054c80-9eb1-4c0f-90f6-977c6deafa8a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("58b65f15-b82c-4882-859f-10c21e9cc453"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("8a2cd4be-a9cf-4ea4-88ab-7e8efc0daa8a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("a2f801d2-2ea9-44a2-b816-c649f8108584"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("a5fa329e-b771-4715-a23e-7549147d2615"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("ae173435-f7df-44cb-9d4c-0a344819437a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("cd4937c1-a882-40fd-a9e1-7874bd20174c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("d32c0e33-2650-4459-9364-ab3138080e90"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("f080d2cb-6fbd-4785-9d46-740cb33d30f7"));

            migrationBuilder.UpdateData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[,]
                {
                    { new Guid("26998c6b-ec06-4d99-81b9-e40050d3387c"), "Hammersborggata 2", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9350), "contact@sparebank1.no", false, false, null, null, "SpareBank 1", 947032579, "91504800", 106, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("28537f7f-6609-4fa3-b4a2-f0893ac238e2"), "Snarøyveien 30", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Fornebu", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9290), "contact@telenor.com", false, false, null, null, "Telenor", 911066905, "67800000", 1360, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("38039fa0-a8b2-4a47-a0fe-0c5ce7c48b1f"), "Hamar", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Hedmark", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9350), "contact@norsk-tipping.no", false, false, null, null, "Norsk Tipping", 982480105, "62508750", 2325, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("469039b4-d4c6-4d56-89de-da79974ff088"), "Lakkegata 23", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9340), "contact@tine.no", false, false, null, null, "Tine", 874560982, "03080", 187, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("4d43f545-e9a4-4918-99b2-fa209221f0c7"), "Skøyen", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9330), "contact@orkla.no", false, false, null, null, "Orkla", 910747711, "22542000", 277, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("623e28e5-a181-4c46-aecf-40b6de43fbdb"), "Drammensveien 131", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9320), "contact@yara.com", false, false, null, null, "Yara International", 919937882, "24155000", 277, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("789af2c5-708a-4f73-9571-57b0e3cafe4a"), "Dronning Eufemias gate 30", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9320), "contact@dnb.no", false, false, null, null, "DNB", 984851006, "91504800", 191, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("8e39cdfa-b23a-4996-8d3a-3604c3992856"), "Drammensveien 260", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9310), "contact@hydro.com", false, false, null, null, "Norsk Hydro", 914778271, "22532000", 283, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("e8b4145d-961b-48ed-b118-d41ae5afb2e7"), "Forusbeen 50", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Stavanger", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9300), "contact@equinor.com", false, false, null, null, "Equinor", 923609016, "51990000", 4035, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("ed4d5bda-f61f-4213-a69a-74b1fb0ad8de"), "Schweigaards gate 21", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9340), "contact@gjensidige.no", false, false, null, null, "Gjensidige", 995568217, "91503100", 191, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") }
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "BusinessId", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "Password", "PhoneNumber", "RoleId", "Username" },
                values: new object[] { new Guid("267ce472-e11c-4bd4-82bf-e42898d78189"), new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), new Guid("64461390-7119-4386-a7d2-01171f054582"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(7670), "benjamin@gmail.com", false, null, null, "Benjamin", "$2a$11$EDzi.7kQQIPs4DiQQnImPO4WNYL6F6TqG8YBrm07ZPom3.6cCadMO", "12345678", new Guid("ccafb929-aa82-4981-96f9-53864b688c89"), "benjamin12345" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactId", "CreatedBy", "CreatedOn", "CustomerId", "Email", "IsDeleted", "ModifiedBy", "ModifiedOn", "Name", "PhoneNumber", "Position" },
                values: new object[] { new Guid("f66e28c4-5aaf-4e02-a8dd-56a51ee153c4"), new Guid("57a8bc51-e1c2-43c7-807d-c07b182b5dcc"), new DateTime(2024, 6, 14, 8, 42, 30, 861, DateTimeKind.Utc).AddTicks(9700), new Guid("28537f7f-6609-4fa3-b4a2-f0893ac238e2"), "Test@Test.no", false, null, null, "Test kontakt", "12345678", "Mellomleder" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: new Guid("f66e28c4-5aaf-4e02-a8dd-56a51ee153c4"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("26998c6b-ec06-4d99-81b9-e40050d3387c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("38039fa0-a8b2-4a47-a0fe-0c5ce7c48b1f"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("469039b4-d4c6-4d56-89de-da79974ff088"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("4d43f545-e9a4-4918-99b2-fa209221f0c7"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("623e28e5-a181-4c46-aecf-40b6de43fbdb"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("789af2c5-708a-4f73-9571-57b0e3cafe4a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("8e39cdfa-b23a-4996-8d3a-3604c3992856"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("e8b4145d-961b-48ed-b118-d41ae5afb2e7"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("ed4d5bda-f61f-4213-a69a-74b1fb0ad8de"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("267ce472-e11c-4bd4-82bf-e42898d78189"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("28537f7f-6609-4fa3-b4a2-f0893ac238e2"));

            migrationBuilder.UpdateData(
                table: "Business",
                keyColumn: "BusinessId",
                keyValue: new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[,]
                {
                    { new Guid("1517ea94-0b62-4906-bfd0-8bedae30baff"), "Hamar", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Hedmark", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4340), "contact@norsk-tipping.no", false, false, null, null, "Norsk Tipping", 982480105, "62508750", 2325, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("41054c80-9eb1-4c0f-90f6-977c6deafa8a"), "Skøyen", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4310), "contact@orkla.no", false, false, null, null, "Orkla", 910747711, "22542000", 277, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("58b65f15-b82c-4882-859f-10c21e9cc453"), "Snarøyveien 30", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Fornebu", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4270), "contact@telenor.com", false, false, null, null, "Telenor", 911066905, "67800000", 1360, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("8a2cd4be-a9cf-4ea4-88ab-7e8efc0daa8a"), "Dronning Eufemias gate 30", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4300), "contact@dnb.no", false, false, null, null, "DNB", 984851006, "91504800", 191, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("a2f801d2-2ea9-44a2-b816-c649f8108584"), "Lakkegata 23", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4330), "contact@tine.no", false, false, null, null, "Tine", 874560982, "03080", 187, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("a5fa329e-b771-4715-a23e-7549147d2615"), "Drammensveien 260", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4290), "contact@hydro.com", false, false, null, null, "Norsk Hydro", 914778271, "22532000", 283, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("ae173435-f7df-44cb-9d4c-0a344819437a"), "Schweigaards gate 21", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4340), "contact@gjensidige.no", false, false, null, null, "Gjensidige", 995568217, "91503100", 191, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("cd4937c1-a882-40fd-a9e1-7874bd20174c"), "Forusbeen 50", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Stavanger", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4280), "contact@equinor.com", false, false, null, null, "Equinor", 923609016, "51990000", 4035, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("d32c0e33-2650-4459-9364-ab3138080e90"), "Drammensveien 131", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4290), "contact@yara.com", false, false, null, null, "Yara International", 919937882, "24155000", 277, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("f080d2cb-6fbd-4785-9d46-740cb33d30f7"), "Hammersborggata 2", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(4350), "contact@sparebank1.no", false, false, null, null, "SpareBank 1", 947032579, "91504800", 106, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") }
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 45, 29, 58, DateTimeKind.Utc).AddTicks(2860));
        }
    }
}
