using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.ShoppingCartAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCartDeatilsColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrductId",
                table: "CartDetails",
                newName: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "CartDetails",
                newName: "PrductId");
        }
    }
}
