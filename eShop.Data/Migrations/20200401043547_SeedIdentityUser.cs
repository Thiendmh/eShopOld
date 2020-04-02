using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 1, 11, 35, 46, 248, DateTimeKind.Local).AddTicks(2314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 1, 10, 44, 38, 960, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("0eb639a2-ecf9-4273-817d-33a208601268"), "010ffe18-5bf2-47d3-9d55-53cb4e75cd54", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("c53f0fe1-29d1-49fb-8b09-5c25ceb4fcfe"), new Guid("0eb639a2-ecf9-4273-817d-33a208601268") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c53f0fe1-29d1-49fb-8b09-5c25ceb4fcfe"), 0, "0f462038-2789-4a31-9f5b-2645375e8112", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "dinhducthien@gmail.com", true, "Thien", "Dinh", false, null, "dinhducthien@gmail.com", "admin", "AQAAAAEAACcQAAAAECRcdxp+dlwKxhaYw6Kj0XHqDfhzFgEggj9tWVRE/RR7MbZm1wK0mXngCg9Mav+5Rw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 1, 11, 35, 46, 272, DateTimeKind.Local).AddTicks(4997));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0eb639a2-ecf9-4273-817d-33a208601268"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c53f0fe1-29d1-49fb-8b09-5c25ceb4fcfe"), new Guid("0eb639a2-ecf9-4273-817d-33a208601268") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c53f0fe1-29d1-49fb-8b09-5c25ceb4fcfe"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 1, 10, 44, 38, 960, DateTimeKind.Local).AddTicks(1326),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 1, 11, 35, 46, 248, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 1, 10, 44, 38, 983, DateTimeKind.Local).AddTicks(5369));
        }
    }
}
