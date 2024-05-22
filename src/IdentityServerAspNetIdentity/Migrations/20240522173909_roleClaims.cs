using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityServerAspNetIdentity.Migrations
{
    /// <inheritdoc />
    public partial class roleClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "653bb917-ac53-464e-9e41-1be6fa6cf9e1", "3bd2f030-453b-45a1-89a2-9cade395d7c1" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 55, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "admin", "f389e134-488c-4fd5-b56c-9fb9f0b3b7f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bd2f030-453b-45a1-89a2-9cade395d7c1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f83c0633-0b66-42df-b671-f11256e13dac", "AQAAAAIAAYagAAAAEHMMMbSUx3b6F/j8ABxlCcK/BfY8Ejmq1VaCMftJDJFqcDbTZqaf7m6DXvN83VOywg==", "72825ab2-40ea-4a57-b48e-e86397ee7b77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f389e134-488c-4fd5-b56c-9fb9f0b3b7f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f23506a-c43e-4840-890f-0c7a56457e27", "AQAAAAIAAYagAAAAEAdn3y/A05eWOMOlcKVIN5pxF/VcSaNp4kHnA0eBnHrxewfbD0cwIXAKYiQa97XdAg==", "9dbf4b70-f37e-490c-83e1-2c3aa680394b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "653bb917-ac53-464e-9e41-1be6fa6cf9e1", "3bd2f030-453b-45a1-89a2-9cade395d7c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bd2f030-453b-45a1-89a2-9cade395d7c1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4efe146a-f11e-43ca-b7ea-1518eaf5ce34", "AQAAAAIAAYagAAAAENpK2Hu0ogZDrBxrba0t90ah162r9DZo9tFKW1S9uMTkMc5g5xPThtuD3BAJGL10ZQ==", "01b24a16-22e2-47cb-89d2-bc44d44a339b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f389e134-488c-4fd5-b56c-9fb9f0b3b7f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61f8e2b8-3b12-4495-b1a9-9bfbbd05a80e", "AQAAAAIAAYagAAAAEGeSoU+pMLyIwoIP0Mq0jb0Y5gXPQ8tavctJ4mDOZSuWI2iGblyHKYAxmT3jvIlONw==", "6ba3d175-841d-4a98-9003-00e6cdeb4675" });
        }
    }
}
