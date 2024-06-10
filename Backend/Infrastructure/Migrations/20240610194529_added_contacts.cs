using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_contacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("1fdabacd-d880-4122-bda8-20ae0e2f6bb6"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("4405a645-ded6-4405-bf80-3a26df0f2379"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("700bde08-952d-4a79-93a1-b41c96df884a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("8fb2e892-4e18-44e8-a4ef-bf2c84826a6c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("a52ed479-c8bf-4f1d-af9a-ecc922d1cd96"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("a812697d-0efd-48f3-af26-6b48f9e3bc78"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("b125a386-99c2-4d1a-89b6-9c9c17c1d314"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("ce7865da-01fd-4153-a9e9-be2e61477d10"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("f2aec781-0842-4e11-98b4-d0dd332daee4"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: new Guid("f4a547c2-c9ae-4cd3-b1a8-db26fcbb8c24"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "BusinessId", "County", "CreatedBy", "CreatedOn", "Email", "IsDeleted", "IsPrivateCustomer", "ModifiedBy", "ModifiedOn", "Name", "OrganizationNr", "PhoneNumber", "PostCode", "StatusId" },
                values: new object[,]
                {
                    { new Guid("1fdabacd-d880-4122-bda8-20ae0e2f6bb6"), "Drammensveien 131", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(4980), "contact@yara.com", false, false, null, null, "Yara International", 919937882, "24155000", 277, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("4405a645-ded6-4405-bf80-3a26df0f2379"), "Drammensveien 260", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(4970), "contact@hydro.com", false, false, null, null, "Norsk Hydro", 914778271, "22532000", 283, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("700bde08-952d-4a79-93a1-b41c96df884a"), "Hammersborggata 2", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(5010), "contact@sparebank1.no", false, false, null, null, "SpareBank 1", 947032579, "91504800", 106, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("8fb2e892-4e18-44e8-a4ef-bf2c84826a6c"), "Forusbeen 50", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Stavanger", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(4960), "contact@equinor.com", false, false, null, null, "Equinor", 923609016, "51990000", 4035, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("a52ed479-c8bf-4f1d-af9a-ecc922d1cd96"), "Snarøyveien 30", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Fornebu", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(4960), "contact@telenor.com", false, false, null, null, "Telenor", 911066905, "67800000", 1360, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("a812697d-0efd-48f3-af26-6b48f9e3bc78"), "Dronning Eufemias gate 30", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(4980), "contact@dnb.no", false, false, null, null, "DNB", 984851006, "91504800", 191, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("b125a386-99c2-4d1a-89b6-9c9c17c1d314"), "Skøyen", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(4990), "contact@orkla.no", false, false, null, null, "Orkla", 910747711, "22542000", 277, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("ce7865da-01fd-4153-a9e9-be2e61477d10"), "Hamar", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Hedmark", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(5000), "contact@norsk-tipping.no", false, false, null, null, "Norsk Tipping", 982480105, "62508750", 2325, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("f2aec781-0842-4e11-98b4-d0dd332daee4"), "Schweigaards gate 21", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(5000), "contact@gjensidige.no", false, false, null, null, "Gjensidige", 995568217, "91503100", 191, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") },
                    { new Guid("f4a547c2-c9ae-4cd3-b1a8-db26fcbb8c24"), "Lakkegata 23", new Guid("e3ead016-1f61-4dc9-b0f1-1f4ee2f27c16"), "Oslo", new Guid("e3611b6c-0380-46bd-b07f-0a3b85a52464"), new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(4990), "contact@tine.no", false, false, null, null, "Tine", 874560982, "03080", 187, new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c") }
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("ccafb929-aa82-4981-96f9-53864b688c89"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("dd5a13da-11e4-4554-a697-76a4102fd72e"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("08bc99d4-87ac-4f56-89e9-af19ab20ab95"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("2b8cc7ea-d47b-4d01-90d9-1581ce380422"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("60e8fa5e-560d-41f7-b16c-593e5b0cfd3b"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("728df2fc-4cbc-4945-8deb-b4e500f1898c"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("edd4e8aa-d3bd-40f1-8a97-8da40cef43bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(3830));
        }
    }
}
