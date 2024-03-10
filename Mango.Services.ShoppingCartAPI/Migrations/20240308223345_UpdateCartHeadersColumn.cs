using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.ShoppingCartAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCartHeadersColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "CartHeaders",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CartHeaders",
                newName: "User");
        }
    }
}
