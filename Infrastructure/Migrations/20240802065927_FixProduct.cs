using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrices_Product_ProductId",
                table: "ProductPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPrices",
                table: "ProductPrices");

            migrationBuilder.RenameTable(
                name: "ProductPrices",
                newName: "ProductPrice");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPrices_ProductId",
                table: "ProductPrice",
                newName: "IX_ProductPrice_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPrice",
                table: "ProductPrice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_Product_ProductId",
                table: "ProductPrice",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_Product_ProductId",
                table: "ProductPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPrice",
                table: "ProductPrice");

            migrationBuilder.RenameTable(
                name: "ProductPrice",
                newName: "ProductPrices");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPrice_ProductId",
                table: "ProductPrices",
                newName: "IX_ProductPrices_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPrices",
                table: "ProductPrices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrices_Product_ProductId",
                table: "ProductPrices",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
