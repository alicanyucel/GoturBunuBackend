using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class Test_Permission_Claim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "GetTestDataListQueryPermission");

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[] { 3, "https://goturbunu.com/identity/claims/permission", "StoreRegistryRequestNavigationPermission", "9cf20d1a-9a51-4918-bd1b-29b972057fbf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "StoreRegistryRequestNavigationPermission");
        }
    }
}
