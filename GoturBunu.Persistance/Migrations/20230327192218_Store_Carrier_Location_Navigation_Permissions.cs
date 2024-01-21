using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class Store_Carrier_Location_Navigation_Permissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimValue",
                value: "CarrierLocationMapNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "CarrierRegistryRequestNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "GetCurrentLocationListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "GetTestDataListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClaimValue",
                value: "SetCurrentLocationCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "StoreLocationMapNavigationPermission", "9cf20d1a-9a51-4918-bd1b-29b972057fbf" });

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 7, "https://goturbunu.com/identity/claims/permission", "StoreRegistryRequestNavigationPermission", "9cf20d1a-9a51-4918-bd1b-29b972057fbf" },
                    { 8, "https://goturbunu.com/identity/claims/permission", "SetCurrentLocationCommandPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimValue",
                value: "CarrierRegistryRequestNavigationPermission");

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
                column: "ClaimValue",
                value: "StoreRegistryRequestNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "SetCurrentLocationCommandPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" });
        }
    }
}
