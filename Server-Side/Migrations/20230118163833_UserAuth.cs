using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class UserAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CreatedByUsername", "CreatedDate", "CustomerName", "Type", "Username" },
                values: new object[,]
                {
                    { new Guid("33c73432-a1ba-4d56-80b1-1f794f2a23a1"), "admin3", new DateTime(2023, 1, 18, 11, 38, 33, 568, DateTimeKind.Local).AddTicks(3400), "Apple", 2, null },
                    { new Guid("4d03aafa-18ba-400d-aa63-32b0912670da"), "admin5", new DateTime(2023, 1, 18, 11, 38, 33, 568, DateTimeKind.Local).AddTicks(3410), "Google", 4, null },
                    { new Guid("5ad03ef0-6b42-4b8d-a941-29f3d2221f0b"), "admin4", new DateTime(2023, 1, 18, 11, 38, 33, 568, DateTimeKind.Local).AddTicks(3407), "Microsoft", 3, null },
                    { new Guid("629bf6a8-6df8-4a51-a900-2269f1a57b3c"), "user", new DateTime(2023, 1, 18, 11, 38, 33, 568, DateTimeKind.Local).AddTicks(3397), "Taget", 1, null },
                    { new Guid("6acbdf4f-fa96-4399-a339-22f591e5342a"), "admin", new DateTime(2023, 1, 18, 11, 38, 33, 568, DateTimeKind.Local).AddTicks(3355), "Kroger", 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin",
                column: "Token",
                value: "62300401-243d-4080-8413-0a4c94b1baad");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin3",
                column: "Token",
                value: "4ba26cbc-1c66-40a4-b085-5f52e9e64492");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin4",
                column: "Token",
                value: "db5876e4-96f8-41be-900f-ec775f6354a4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin5",
                column: "Token",
                value: "f6c73e20-0e92-4c8d-a98d-a0e8c6b1e3dc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "user",
                column: "Token",
                value: "d3cc750d-9a48-4bc4-8f4b-0b1c9c93be5b");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("33c73432-a1ba-4d56-80b1-1f794f2a23a1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("4d03aafa-18ba-400d-aa63-32b0912670da"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("5ad03ef0-6b42-4b8d-a941-29f3d2221f0b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("629bf6a8-6df8-4a51-a900-2269f1a57b3c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("6acbdf4f-fa96-4399-a339-22f591e5342a"));

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Users");

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
    }
}
