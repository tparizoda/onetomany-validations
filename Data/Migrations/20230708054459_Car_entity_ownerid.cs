using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tasks.Data.Migrations
{
    /// <inheritdoc />
    public partial class Car_entity_ownerid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_OwnerId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Cars",
                newName: "OWnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_OwnerId",
                table: "Cars",
                newName: "IX_Cars_OWnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_OWnerId",
                table: "Cars",
                column: "OWnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_OWnerId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "OWnerId",
                table: "Cars",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_OWnerId",
                table: "Cars",
                newName: "IX_Cars_OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_OwnerId",
                table: "Cars",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
