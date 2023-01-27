using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class UserAuthV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("24caea9f-4e64-4e7f-a654-6eb1af5ecea5"), "admin3", new DateTime(2023, 1, 18, 12, 10, 21, 486, DateTimeKind.Local).AddTicks(4243), "Apple", 2, null },
                    { new Guid("647d7f9c-6765-4248-b574-bb2865a69a9f"), "admin4", new DateTime(2023, 1, 18, 12, 10, 21, 486, DateTimeKind.Local).AddTicks(4246), "Microsoft", 3, null },
                    { new Guid("7531937e-b8bb-4bb9-8fa8-f19361d18029"), "user", new DateTime(2023, 1, 18, 12, 10, 21, 486, DateTimeKind.Local).AddTicks(4240), "Taget", 1, null },
                    { new Guid("c9415dd9-ef5a-4bad-a8a6-28d26932a957"), "admin5", new DateTime(2023, 1, 18, 12, 10, 21, 486, DateTimeKind.Local).AddTicks(4248), "Google", 4, null },
                    { new Guid("d2d075ce-a029-426c-b1ef-4503fd30debb"), "admin", new DateTime(2023, 1, 18, 12, 10, 21, 486, DateTimeKind.Local).AddTicks(4211), "Kroger", 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("24caea9f-4e64-4e7f-a654-6eb1af5ecea5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("647d7f9c-6765-4248-b574-bb2865a69a9f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7531937e-b8bb-4bb9-8fa8-f19361d18029"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("c9415dd9-ef5a-4bad-a8a6-28d26932a957"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("d2d075ce-a029-426c-b1ef-4503fd30debb"));

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
    }
}
