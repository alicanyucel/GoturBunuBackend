using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoturBunu.Persistance.Migrations
{
    public partial class Store_Details_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreDetails_Users_UserId",
                table: "StoreDetails");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "StoreDetails",
                newName: "StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreDetails_UserId",
                table: "StoreDetails",
                newName: "IX_StoreDetails_StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreDetails_Users_StoreId",
                table: "StoreDetails",
                column: "StoreId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreDetails_Users_StoreId",
                table: "StoreDetails");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "StoreDetails",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreDetails_StoreId",
                table: "StoreDetails",
                newName: "IX_StoreDetails_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreDetails_Users_UserId",
                table: "StoreDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
