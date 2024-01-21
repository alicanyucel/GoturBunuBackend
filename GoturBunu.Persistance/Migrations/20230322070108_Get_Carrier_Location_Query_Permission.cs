using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class Get_Carrier_Location_Query_Permission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "GetCurrentLocationListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "GetTestDataListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "SetCurrentLocationCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "StoreRegistryRequestNavigationPermission", "9cf20d1a-9a51-4918-bd1b-29b972057fbf" });

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[] { 6, "https://goturbunu.com/identity/claims/permission", "SetCurrentLocationCommandPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "GetTestDataListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "SetCurrentLocationCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "StoreRegistryRequestNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "SetCurrentLocationCommandPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" });
        }
    }
}
