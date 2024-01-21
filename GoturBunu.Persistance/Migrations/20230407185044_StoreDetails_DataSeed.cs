using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class StoreDetails_DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StoreDetails",
                columns: new[] { "Id", "CreatedAt", "Location", "ModifiedAt", "Name", "UserId" },
                values: new object[] { "80a20379-193e-4342-944b-8b3f8c929dc9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.925533 32.866287)"), null, "GOTUR BUNU STORE", "36125b81-d8c6-4665-9c2f-ec95db4e8eac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreDetails",
                keyColumn: "Id",
                keyValue: "80a20379-193e-4342-944b-8b3f8c929dc9");
        }
    }
}
