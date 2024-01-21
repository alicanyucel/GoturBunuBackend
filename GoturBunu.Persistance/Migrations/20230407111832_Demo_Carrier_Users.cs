using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class Demo_Carrier_Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b290621-72de-4825-9f31-c510664d4ca9", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier2@goturbunu.com", false, true, null, "CARRIER2@GOTURBUNU.COM", "CARRIER2", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier2" },
                    { "238160d0-8a4b-4553-85e6-110290ff6878", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier1@goturbunu.com", false, true, null, "CARRIER1@GOTURBUNU.COM", "CARRIER1", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier1" },
                    { "541afee1-ccf5-426b-9ed7-cc8087a3d00b", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier3@goturbunu.com", false, true, null, "CARRIER3@GOTURBUNU.COM", "CARRIER3", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier3" },
                    { "64c40294-ef97-4354-aa2c-c95d4ca61267", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier4@goturbunu.com", false, true, null, "CARRIER4@GOTURBUNU.COM", "CARRIER4", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier4" },
                    { "66d9e051-4961-4aad-9408-eef68716411b", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier9@goturbunu.com", false, true, null, "CARRIER9@GOTURBUNU.COM", "CARRIER9", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier9" },
                    { "95defd0e-26a7-4c60-b5ab-79ba66a7f788", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier6@goturbunu.com", false, true, null, "CARRIER6@GOTURBUNU.COM", "CARRIER6", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier6" },
                    { "9905504a-d071-440f-96ad-3d3ddf38c248", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier8@goturbunu.com", false, true, null, "CARRIER8@GOTURBUNU.COM", "CARRIER8", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier8" },
                    { "adeb25b4-4fd7-41cf-9cae-f6698febbbea", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier7@goturbunu.com", false, true, null, "CARRIER7@GOTURBUNU.COM", "CARRIER7", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier7" },
                    { "bf67c7fc-2e77-4e96-a08f-a930345c2150", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier5@goturbunu.com", false, true, null, "CARRIER5@GOTURBUNU.COM", "CARRIER5", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier5" },
                    { "f50590d5-1f85-4f6c-93c8-ec17aebe31b0", 0, "0320320e-a3e3-457b-8a74-188d4f16fefb", "carrier10@goturbunu.com", false, true, null, "CARRIER10@GOTURBUNU.COM", "CARRIER10", "AQAAAAEAAC7gAAAAEBK2NqcIbdVmeEtwpc9MUpHux9pscMSJoncY3Acwzomjpi322ZkZtLTbwrRDta7eLA==", null, false, "QPZ2ADTAD5UKI7J5OACQI2HULBVCLPQI", false, "carrier10" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "0b290621-72de-4825-9f31-c510664d4ca9" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "238160d0-8a4b-4553-85e6-110290ff6878" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "541afee1-ccf5-426b-9ed7-cc8087a3d00b" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "64c40294-ef97-4354-aa2c-c95d4ca61267" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "66d9e051-4961-4aad-9408-eef68716411b" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "95defd0e-26a7-4c60-b5ab-79ba66a7f788" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "9905504a-d071-440f-96ad-3d3ddf38c248" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "adeb25b4-4fd7-41cf-9cae-f6698febbbea" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "bf67c7fc-2e77-4e96-a08f-a930345c2150" },
                    { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "f50590d5-1f85-4f6c-93c8-ec17aebe31b0" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "0b290621-72de-4825-9f31-c510664d4ca9" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "238160d0-8a4b-4553-85e6-110290ff6878" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "541afee1-ccf5-426b-9ed7-cc8087a3d00b" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "64c40294-ef97-4354-aa2c-c95d4ca61267" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "66d9e051-4961-4aad-9408-eef68716411b" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "95defd0e-26a7-4c60-b5ab-79ba66a7f788" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "9905504a-d071-440f-96ad-3d3ddf38c248" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "adeb25b4-4fd7-41cf-9cae-f6698febbbea" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "bf67c7fc-2e77-4e96-a08f-a930345c2150" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb7ac2d9-b240-4d91-a2c9-d70072cefc64", "f50590d5-1f85-4f6c-93c8-ec17aebe31b0" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0b290621-72de-4825-9f31-c510664d4ca9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "238160d0-8a4b-4553-85e6-110290ff6878");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "541afee1-ccf5-426b-9ed7-cc8087a3d00b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "64c40294-ef97-4354-aa2c-c95d4ca61267");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "66d9e051-4961-4aad-9408-eef68716411b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "95defd0e-26a7-4c60-b5ab-79ba66a7f788");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9905504a-d071-440f-96ad-3d3ddf38c248");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "adeb25b4-4fd7-41cf-9cae-f6698febbbea");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bf67c7fc-2e77-4e96-a08f-a930345c2150");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f50590d5-1f85-4f6c-93c8-ec17aebe31b0");
        }
    }
}
