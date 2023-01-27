using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class userAuth21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PermissionLevel",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CreatedByUsername", "CreatedDate", "CustomerName", "Type", "Username" },
                values: new object[,]
                {
                    { new Guid("2e7425b1-8368-449a-9ba5-3fdea067ca5f"), "admin3", new DateTime(2023, 1, 18, 12, 33, 15, 426, DateTimeKind.Local).AddTicks(9228), "Apple", 2, null },
                    { new Guid("37689bcf-2c82-4b65-960e-9e93a09259b0"), "admin", new DateTime(2023, 1, 18, 12, 33, 15, 426, DateTimeKind.Local).AddTicks(9195), "Kroger", 0, null },
                    { new Guid("b6116f2a-2cbb-49a3-a6bd-b79a6562294f"), "user", new DateTime(2023, 1, 18, 12, 33, 15, 426, DateTimeKind.Local).AddTicks(9225), "Taget", 1, null },
                    { new Guid("cda14833-77ee-4a7a-bc23-b12f30b130ee"), "admin4", new DateTime(2023, 1, 18, 12, 33, 15, 426, DateTimeKind.Local).AddTicks(9231), "Microsoft", 3, null },
                    { new Guid("f3659478-b11d-49ae-b7e4-6b066be9c841"), "admin5", new DateTime(2023, 1, 18, 12, 33, 15, 426, DateTimeKind.Local).AddTicks(9234), "Google", 4, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin",
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=", "admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin3",
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=", "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin4",
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=", "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin5",
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=", "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "user",
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "BPiZbadjt6lpsQKO4wB1aerzpjVIbdqyEdUSyFud+Ps=", "user" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("2e7425b1-8368-449a-9ba5-3fdea067ca5f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("37689bcf-2c82-4b65-960e-9e93a09259b0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("b6116f2a-2cbb-49a3-a6bd-b79a6562294f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("cda14833-77ee-4a7a-bc23-b12f30b130ee"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f3659478-b11d-49ae-b7e4-6b066be9c841"));

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "PermissionLevel",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin",
                columns: new[] { "PasswordHash", "PermissionLevel" },
                values: new object[] { "admin", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin3",
                columns: new[] { "PasswordHash", "PermissionLevel" },
                values: new object[] { "admin", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin4",
                columns: new[] { "PasswordHash", "PermissionLevel" },
                values: new object[] { "admin", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "admin5",
                columns: new[] { "PasswordHash", "PermissionLevel" },
                values: new object[] { "admin", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "user",
                columns: new[] { "PasswordHash", "PermissionLevel" },
                values: new object[] { "admin", 1 });
        }
    }
}
