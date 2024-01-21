using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class Store_User_And_Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "36125b81-d8c6-4665-9c2f-ec95db4e8eac", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "store@goturbunu.com", false, true, null, "STORE@GOTURBUNU.COM", "STORE", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "store" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0bd95914-44ff-4f4d-bf02-e083d77b75fa", "36125b81-d8c6-4665-9c2f-ec95db4e8eac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0bd95914-44ff-4f4d-bf02-e083d77b75fa", "36125b81-d8c6-4665-9c2f-ec95db4e8eac" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36125b81-d8c6-4665-9c2f-ec95db4e8eac");
        }
    }
}
