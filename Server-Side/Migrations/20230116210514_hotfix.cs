using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class hotfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "FirstName", "LastName", "PasswordHash", "PermissionLevel", "PhoneNumber" },
                values: new object[,]
                {
                    { "admin", "Bryan", "Rodriguez", "admin", 3, "8126972996" },
                    { "admin3", "Bryan", "Rodriguez", "admin", 3, "8126972996" },
                    { "admin4", "Bryan", "Rodriguez", "admin", 3, "8126972996" },
                    { "admin5", "Bryan", "Rodriguez", "admin", 3, "8126972996" },
                    { "user", "Bryan", "Rodriguez", "admin", 1, "8126972996" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "user");
        }
    }
}
