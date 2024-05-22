using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityServerAspNetIdentity.Migrations
{
    /// <inheritdoc />
    public partial class AjoutPropsIsAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsManager",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bd2f030-453b-45a1-89a2-9cade395d7c1",
                columns: new[] { "ConcurrencyStamp", "IsAdmin", "IsManager", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4efe146a-f11e-43ca-b7ea-1518eaf5ce34", false, true, "AQAAAAIAAYagAAAAENpK2Hu0ogZDrBxrba0t90ah162r9DZo9tFKW1S9uMTkMc5g5xPThtuD3BAJGL10ZQ==", "01b24a16-22e2-47cb-89d2-bc44d44a339b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f389e134-488c-4fd5-b56c-9fb9f0b3b7f3",
                columns: new[] { "ConcurrencyStamp", "IsAdmin", "IsManager", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61f8e2b8-3b12-4495-b1a9-9bfbbd05a80e", true, false, "AQAAAAIAAYagAAAAEGeSoU+pMLyIwoIP0Mq0jb0Y5gXPQ8tavctJ4mDOZSuWI2iGblyHKYAxmT3jvIlONw==", "6ba3d175-841d-4a98-9003-00e6cdeb4675" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsManager",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bd2f030-453b-45a1-89a2-9cade395d7c1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e8ea96b-4674-4e58-aabd-eb1f009ba98b", "AQAAAAIAAYagAAAAEK/PhDO00E+c/Cdov89jkFn4QtZo5F9sGMXgL7NQjCXJSsD5/XKOlJy48QPgmXMGvQ==", "8bf6bec1-61ef-4754-9a99-204b4a381c3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f389e134-488c-4fd5-b56c-9fb9f0b3b7f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6aa5bad-1ddc-4d01-beba-709a927147db", "AQAAAAIAAYagAAAAEFqiEJUY5x6sPxn+oCG1S0JI9TOctizziGz54MQ53QYptuH4d2bHx/cb1IBeWUaCVA==", "14040b93-f582-4085-8652-573afdc94738" });
        }
    }
}
