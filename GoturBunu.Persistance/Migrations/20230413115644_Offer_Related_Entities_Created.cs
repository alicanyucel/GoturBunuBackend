using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class Offer_Related_Entities_Created : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Users_CarrierId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Response",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "ResponseTime",
                table: "Offers");

            migrationBuilder.RenameColumn(
                name: "CarrierId",
                table: "Offers",
                newName: "PacketId");

            migrationBuilder.RenameIndex(
                name: "IX_Offers_CarrierId",
                table: "Offers",
                newName: "IX_Offers_PacketId");

            migrationBuilder.CreateTable(
                name: "OfferStages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OfferId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferStages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferStages_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StoreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Location = table.Column<Point>(type: "geography", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packets_Users_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrierOffers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarrierId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Response = table.Column<int>(type: "int", nullable: false),
                    OfferStageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrierOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrierOffers_OfferStages_OfferStageId",
                        column: x => x.OfferStageId,
                        principalTable: "OfferStages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarrierOffers_Users_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "CreateOfferCommandPermission");

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
                value: "SetCurrentLocationCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "StoreRegistryRequestNavigationPermission", "9cf20d1a-9a51-4918-bd1b-29b972057fbf" });

            migrationBuilder.InsertData(
                table: "RoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[] { 9, "https://goturbunu.com/identity/claims/permission", "SetCurrentLocationCommandPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" });

            migrationBuilder.CreateIndex(
                name: "IX_CarrierOffers_CarrierId",
                table: "CarrierOffers",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrierOffers_OfferStageId",
                table: "CarrierOffers",
                column: "OfferStageId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferStages_OfferId",
                table: "OfferStages",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Packets_StoreId",
                table: "Packets",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Packets_PacketId",
                table: "Offers",
                column: "PacketId",
                principalTable: "Packets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Packets_PacketId",
                table: "Offers");

            migrationBuilder.DropTable(
                name: "CarrierOffers");

            migrationBuilder.DropTable(
                name: "Packets");

            migrationBuilder.DropTable(
                name: "OfferStages");

            migrationBuilder.DeleteData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.RenameColumn(
                name: "PacketId",
                table: "Offers",
                newName: "CarrierId");

            migrationBuilder.RenameIndex(
                name: "IX_Offers_PacketId",
                table: "Offers",
                newName: "IX_Offers_CarrierId");

            migrationBuilder.AddColumn<int>(
                name: "Response",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResponseTime",
                table: "Offers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                value: "GetLocationListQueryPermission");

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
                value: "LiveMapNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "ClaimValue",
                value: "SetCurrentLocationCommandPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "ClaimValue",
                value: "StoreRegistryRequestNavigationPermission");

            migrationBuilder.UpdateData(
                table: "RoleClaims",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "SetCurrentLocationCommandPermission", "fb7ac2d9-b240-4d91-a2c9-d70072cefc64" });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Users_CarrierId",
                table: "Offers",
                column: "CarrierId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
