using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class hotfix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("09a38f39-ff12-428c-8f53-e1f84bae6e1e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("57b3820d-1efb-4722-9a85-2cbbc8ae1be1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("5895d84c-1cfe-4167-860c-40ebe4a516c9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("71a4b3e2-8aa5-43d2-8f9c-88f3b58029ee"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f916d998-f731-4384-9a0b-8269c574f679"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CreatedByUsername", "CreatedDate", "CustomerName", "Type", "Username" },
                values: new object[,]
                {
                    { new Guid("14ed452a-1075-46a1-8270-93e66f5443bf"), "admin4", new DateTime(2023, 1, 16, 16, 12, 33, 947, DateTimeKind.Local).AddTicks(1735), "Microsoft", 3, null },
                    { new Guid("2138404a-86ad-4fb6-be2e-1dcc9afbbc33"), "admin5", new DateTime(2023, 1, 16, 16, 12, 33, 947, DateTimeKind.Local).AddTicks(1738), "Google", 4, null },
                    { new Guid("54c9fcd0-a7fb-4c85-94c2-80c35bedee60"), "admin", new DateTime(2023, 1, 16, 16, 12, 33, 947, DateTimeKind.Local).AddTicks(1689), "Kroger", 0, null },
                    { new Guid("89334755-9dd8-4f65-9c75-2eb3285e99c2"), "user", new DateTime(2023, 1, 16, 16, 12, 33, 947, DateTimeKind.Local).AddTicks(1728), "Taget", 1, null },
                    { new Guid("e7e9fb43-ef8b-424c-9699-0881d38be0e1"), "admin3", new DateTime(2023, 1, 16, 16, 12, 33, 947, DateTimeKind.Local).AddTicks(1731), "Apple", 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("14ed452a-1075-46a1-8270-93e66f5443bf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("2138404a-86ad-4fb6-be2e-1dcc9afbbc33"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("54c9fcd0-a7fb-4c85-94c2-80c35bedee60"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("89334755-9dd8-4f65-9c75-2eb3285e99c2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e7e9fb43-ef8b-424c-9699-0881d38be0e1"));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CreatedByUsername", "CreatedDate", "CustomerName", "Type", "Username" },
                values: new object[,]
                {
                    { new Guid("09a38f39-ff12-428c-8f53-e1f84bae6e1e"), "admin4", new DateTime(2023, 1, 16, 16, 5, 14, 103, DateTimeKind.Local).AddTicks(3455), "Microsoft", 3, null },
                    { new Guid("57b3820d-1efb-4722-9a85-2cbbc8ae1be1"), "admin", new DateTime(2023, 1, 16, 16, 5, 14, 103, DateTimeKind.Local).AddTicks(3420), "Kroger", 0, null },
                    { new Guid("5895d84c-1cfe-4167-860c-40ebe4a516c9"), "admin5", new DateTime(2023, 1, 16, 16, 5, 14, 103, DateTimeKind.Local).AddTicks(3458), "Google", 4, null },
                    { new Guid("71a4b3e2-8aa5-43d2-8f9c-88f3b58029ee"), "admin3", new DateTime(2023, 1, 16, 16, 5, 14, 103, DateTimeKind.Local).AddTicks(3452), "Apple", 2, null },
                    { new Guid("f916d998-f731-4384-9a0b-8269c574f679"), "user", new DateTime(2023, 1, 16, 16, 5, 14, 103, DateTimeKind.Local).AddTicks(3450), "Taget", 1, null }
                });
        }
    }
}
