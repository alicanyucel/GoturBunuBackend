using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class User_Hub_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HubId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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
                value: "GetLocationListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClaimValue",
                value: "GetTestDataListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "ClaimValue",
                value: "LiveMapNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "ClaimValue",
                value: "OnOfferResponseCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "ClaimValue",
                value: "SendOfferToCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "ClaimValue",
                value: "SetCarrierHubIdCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "SetCurrentLocationCommandPermission", "9cf20d1a-9a51-4918-bd1b-29b972057fbf" });

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "StoreRegistryRequestNavigationPermission", "9cf20d1a-9a51-4918-bd1b-29b972057fbf" });

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 12, "https://goturbunu.com/identity/claims/permission", "CarrierHubConnectionPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" },
                    { 13, "https://goturbunu.com/identity/claims/permission", "SetCurrentLocationCommandPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "HubId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "CreateOfferCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "GetCurrentLocationListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClaimValue",
                value: "GetLocationListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "ClaimValue",
                value: "GetTestDataListQueryPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "ClaimValue",
                value: "LiveMapNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "ClaimValue",
                value: "SetCurrentLocationCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "ClaimValue",
                value: "StoreRegistryRequestNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "CarrierHubConnectionPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" });

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "SetCurrentLocationCommandPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" });
        }
    }
}
