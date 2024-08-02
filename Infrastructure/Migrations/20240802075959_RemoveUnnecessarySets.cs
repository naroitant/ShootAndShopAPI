using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnnecessarySets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Product_ProductId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Sellers_SellerId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Manufacturers_ManufacturerId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Materials_Axe_BladeMaterialId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Materials_Axe_HandleMaterialId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Materials_BladeMaterialId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Materials_HandleMaterialId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Materials_MaterialId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_MagazineId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_ProductId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_RedDotSightId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_ScopeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_RifleActionTypes_RifleActionTypeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ShotgunActionTypes_ShotgunActionTypeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrices_Product_ProductId",
                table: "ProductPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Customers_CustomerId",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sellers",
                table: "Sellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPrices",
                table: "ProductPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "shopping_cart");

            migrationBuilder.RenameTable(
                name: "Sellers",
                newName: "seller");

            migrationBuilder.RenameTable(
                name: "ProductPrices",
                newName: "product_price");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "payment");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "order");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "item");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customer");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_CustomerId",
                table: "shopping_cart",
                newName: "IX_shopping_cart_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPrices_ProductId",
                table: "product_price",
                newName: "IX_product_price_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ShotgunActionTypeId",
                table: "Products",
                newName: "IX_Products_ShotgunActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ScopeId",
                table: "Products",
                newName: "IX_Products_ScopeId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_RifleActionTypeId",
                table: "Products",
                newName: "IX_Products_RifleActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_RedDotSightId",
                table: "Products",
                newName: "IX_Products_RedDotSightId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductId",
                table: "Products",
                newName: "IX_Products_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_MaterialId",
                table: "Products",
                newName: "IX_Products_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ManufacturerId",
                table: "Products",
                newName: "IX_Products_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_MagazineId",
                table: "Products",
                newName: "IX_Products_MagazineId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_HandleMaterialId",
                table: "Products",
                newName: "IX_Products_HandleMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_BladeMaterialId",
                table: "Products",
                newName: "IX_Products_BladeMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Axe_HandleMaterialId",
                table: "Products",
                newName: "IX_Products_Axe_HandleMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Axe_BladeMaterialId",
                table: "Products",
                newName: "IX_Products_Axe_BladeMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_SellerId",
                table: "payment",
                newName: "IX_payment_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "order",
                newName: "IX_order_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ShoppingCartId",
                table: "item",
                newName: "IX_item_ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ProductId",
                table: "item",
                newName: "IX_item_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OrderId",
                table: "item",
                newName: "IX_item_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shopping_cart",
                table: "shopping_cart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_seller",
                table: "seller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product_price",
                table: "product_price",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payment",
                table: "payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_item",
                table: "item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer",
                table: "customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_item_Products_ProductId",
                table: "item",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_item_order_OrderId",
                table: "item",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_item_shopping_cart_ShoppingCartId",
                table: "item",
                column: "ShoppingCartId",
                principalTable: "shopping_cart",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_customer_CustomerId",
                table: "order",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payment_seller_SellerId",
                table: "payment",
                column: "SellerId",
                principalTable: "seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_price_Products_ProductId",
                table: "product_price",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Materials_Axe_BladeMaterialId",
                table: "Products",
                column: "Axe_BladeMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Materials_Axe_HandleMaterialId",
                table: "Products",
                column: "Axe_HandleMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Materials_BladeMaterialId",
                table: "Products",
                column: "BladeMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Materials_HandleMaterialId",
                table: "Products",
                column: "HandleMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Materials_MaterialId",
                table: "Products",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_MagazineId",
                table: "Products",
                column: "MagazineId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductId",
                table: "Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_RedDotSightId",
                table: "Products",
                column: "RedDotSightId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ScopeId",
                table: "Products",
                column: "ScopeId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_RifleActionTypes_RifleActionTypeId",
                table: "Products",
                column: "RifleActionTypeId",
                principalTable: "RifleActionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ShotgunActionTypes_ShotgunActionTypeId",
                table: "Products",
                column: "ShotgunActionTypeId",
                principalTable: "ShotgunActionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_shopping_cart_customer_CustomerId",
                table: "shopping_cart",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_Products_ProductId",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "FK_item_order_OrderId",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "FK_item_shopping_cart_ShoppingCartId",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "FK_order_customer_CustomerId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_payment_seller_SellerId",
                table: "payment");

            migrationBuilder.DropForeignKey(
                name: "FK_product_price_Products_ProductId",
                table: "product_price");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Materials_Axe_BladeMaterialId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Materials_Axe_HandleMaterialId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Materials_BladeMaterialId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Materials_HandleMaterialId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Materials_MaterialId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_MagazineId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_RedDotSightId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ScopeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_RifleActionTypes_RifleActionTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ShotgunActionTypes_ShotgunActionTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_shopping_cart_customer_CustomerId",
                table: "shopping_cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shopping_cart",
                table: "shopping_cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_seller",
                table: "seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product_price",
                table: "product_price");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payment",
                table: "payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_item",
                table: "item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customer",
                table: "customer");

            migrationBuilder.RenameTable(
                name: "shopping_cart",
                newName: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "seller",
                newName: "Sellers");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "product_price",
                newName: "ProductPrices");

            migrationBuilder.RenameTable(
                name: "payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_shopping_cart_CustomerId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ShotgunActionTypeId",
                table: "Product",
                newName: "IX_Product_ShotgunActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ScopeId",
                table: "Product",
                newName: "IX_Product_ScopeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_RifleActionTypeId",
                table: "Product",
                newName: "IX_Product_RifleActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_RedDotSightId",
                table: "Product",
                newName: "IX_Product_RedDotSightId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductId",
                table: "Product",
                newName: "IX_Product_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_MaterialId",
                table: "Product",
                newName: "IX_Product_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ManufacturerId",
                table: "Product",
                newName: "IX_Product_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_MagazineId",
                table: "Product",
                newName: "IX_Product_MagazineId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_HandleMaterialId",
                table: "Product",
                newName: "IX_Product_HandleMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BladeMaterialId",
                table: "Product",
                newName: "IX_Product_BladeMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Axe_HandleMaterialId",
                table: "Product",
                newName: "IX_Product_Axe_HandleMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Axe_BladeMaterialId",
                table: "Product",
                newName: "IX_Product_Axe_BladeMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_product_price_ProductId",
                table: "ProductPrices",
                newName: "IX_ProductPrices_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_payment_SellerId",
                table: "Payments",
                newName: "IX_Payments_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_order_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_item_ShoppingCartId",
                table: "Items",
                newName: "IX_Items_ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_item_ProductId",
                table: "Items",
                newName: "IX_Items_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_item_OrderId",
                table: "Items",
                newName: "IX_Items_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sellers",
                table: "Sellers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPrices",
                table: "ProductPrices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Product_ProductId",
                table: "Items",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartId",
                table: "Items",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Sellers_SellerId",
                table: "Payments",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Manufacturers_ManufacturerId",
                table: "Product",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Materials_Axe_BladeMaterialId",
                table: "Product",
                column: "Axe_BladeMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Materials_Axe_HandleMaterialId",
                table: "Product",
                column: "Axe_HandleMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Materials_BladeMaterialId",
                table: "Product",
                column: "BladeMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Materials_HandleMaterialId",
                table: "Product",
                column: "HandleMaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Materials_MaterialId",
                table: "Product",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_MagazineId",
                table: "Product",
                column: "MagazineId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_ProductId",
                table: "Product",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_RedDotSightId",
                table: "Product",
                column: "RedDotSightId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_ScopeId",
                table: "Product",
                column: "ScopeId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_RifleActionTypes_RifleActionTypeId",
                table: "Product",
                column: "RifleActionTypeId",
                principalTable: "RifleActionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ShotgunActionTypes_ShotgunActionTypeId",
                table: "Product",
                column: "ShotgunActionTypeId",
                principalTable: "ShotgunActionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrices_Product_ProductId",
                table: "ProductPrices",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Customers_CustomerId",
                table: "ShoppingCarts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
