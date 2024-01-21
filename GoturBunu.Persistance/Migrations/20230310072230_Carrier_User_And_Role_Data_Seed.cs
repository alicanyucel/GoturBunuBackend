using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class Carrier_User_And_Role_Data_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "05132bcb-2752-4c5b-87f7-3d884e420df4", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier@goturbunu.com", false, true, null, "CARRIER@GOTURBUNU.COM", "CARRIER", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "05132bcb-2752-4c5b-87f7-3d884e420df4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "05132bcb-2752-4c5b-87f7-3d884e420df4" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "05132bcb-2752-4c5b-87f7-3d884e420df4");
        }
    }
}
