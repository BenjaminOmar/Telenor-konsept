using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class added_contact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserServices");

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

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactId", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contact_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserId", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 43, 20, 781, DateTimeKind.Utc).AddTicks(3620), "User" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CustomerId",
                table: "Contact",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_User_BusinessId",
                table: "User",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "User",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "User");

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

            migrationBuilder.CreateTable(
                name: "UserServices",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserId", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserServices_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserServices_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2024, 5, 24, 20, 29, 55, 350, DateTimeKind.Utc).AddTicks(8400), "UserServices" });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_BusinessId",
                table: "UserServices",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_RoleId",
                table: "UserServices",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_Username",
                table: "UserServices",
                column: "Username",
                unique: true);
        }
    }
}
