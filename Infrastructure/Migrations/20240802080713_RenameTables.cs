using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_Products_ProductId",
                table: "item");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShotgunActionTypes",
                table: "ShotgunActionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SafetyTypes",
                table: "SafetyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RifleActionTypes",
                table: "RifleActionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LockTypes",
                table: "LockTypes");

            migrationBuilder.RenameTable(
                name: "ShotgunActionTypes",
                newName: "shotgun_action_type");

            migrationBuilder.RenameTable(
                name: "SafetyTypes",
                newName: "safety_type");

            migrationBuilder.RenameTable(
                name: "RifleActionTypes",
                newName: "rifle_action_type");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "product");

            migrationBuilder.RenameTable(
                name: "Materials",
                newName: "material");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "manufacturer");

            migrationBuilder.RenameTable(
                name: "LockTypes",
                newName: "lock_type");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ShotgunActionTypeId",
                table: "product",
                newName: "IX_product_ShotgunActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ScopeId",
                table: "product",
                newName: "IX_product_ScopeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_RifleActionTypeId",
                table: "product",
                newName: "IX_product_RifleActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_RedDotSightId",
                table: "product",
                newName: "IX_product_RedDotSightId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductId",
                table: "product",
                newName: "IX_product_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_MaterialId",
                table: "product",
                newName: "IX_product_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ManufacturerId",
                table: "product",
                newName: "IX_product_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_MagazineId",
                table: "product",
                newName: "IX_product_MagazineId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_HandleMaterialId",
                table: "product",
                newName: "IX_product_HandleMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BladeMaterialId",
                table: "product",
                newName: "IX_product_BladeMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Axe_HandleMaterialId",
                table: "product",
                newName: "IX_product_Axe_HandleMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Axe_BladeMaterialId",
                table: "product",
                newName: "IX_product_Axe_BladeMaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shotgun_action_type",
                table: "shotgun_action_type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_safety_type",
                table: "safety_type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rifle_action_type",
                table: "rifle_action_type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_material",
                table: "material",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_manufacturer",
                table: "manufacturer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lock_type",
                table: "lock_type",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_item_product_ProductId",
                table: "item",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_manufacturer_ManufacturerId",
                table: "product",
                column: "ManufacturerId",
                principalTable: "manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_material_Axe_BladeMaterialId",
                table: "product",
                column: "Axe_BladeMaterialId",
                principalTable: "material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_material_Axe_HandleMaterialId",
                table: "product",
                column: "Axe_HandleMaterialId",
                principalTable: "material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_material_BladeMaterialId",
                table: "product",
                column: "BladeMaterialId",
                principalTable: "material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_material_HandleMaterialId",
                table: "product",
                column: "HandleMaterialId",
                principalTable: "material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_material_MaterialId",
                table: "product",
                column: "MaterialId",
                principalTable: "material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_product_MagazineId",
                table: "product",
                column: "MagazineId",
                principalTable: "product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_product_ProductId",
                table: "product",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_product_RedDotSightId",
                table: "product",
                column: "RedDotSightId",
                principalTable: "product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_product_ScopeId",
                table: "product",
                column: "ScopeId",
                principalTable: "product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_rifle_action_type_RifleActionTypeId",
                table: "product",
                column: "RifleActionTypeId",
                principalTable: "rifle_action_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_shotgun_action_type_ShotgunActionTypeId",
                table: "product",
                column: "ShotgunActionTypeId",
                principalTable: "shotgun_action_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_price_product_ProductId",
                table: "product_price",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_product_ProductId",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "FK_product_manufacturer_ManufacturerId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_material_Axe_BladeMaterialId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_material_Axe_HandleMaterialId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_material_BladeMaterialId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_material_HandleMaterialId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_material_MaterialId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_product_MagazineId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_product_ProductId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_product_RedDotSightId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_product_ScopeId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_rifle_action_type_RifleActionTypeId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_shotgun_action_type_ShotgunActionTypeId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_product_price_product_ProductId",
                table: "product_price");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shotgun_action_type",
                table: "shotgun_action_type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_safety_type",
                table: "safety_type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rifle_action_type",
                table: "rifle_action_type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_material",
                table: "material");

            migrationBuilder.DropPrimaryKey(
                name: "PK_manufacturer",
                table: "manufacturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lock_type",
                table: "lock_type");

            migrationBuilder.RenameTable(
                name: "shotgun_action_type",
                newName: "ShotgunActionTypes");

            migrationBuilder.RenameTable(
                name: "safety_type",
                newName: "SafetyTypes");

            migrationBuilder.RenameTable(
                name: "rifle_action_type",
                newName: "RifleActionTypes");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "material",
                newName: "Materials");

            migrationBuilder.RenameTable(
                name: "manufacturer",
                newName: "Manufacturers");

            migrationBuilder.RenameTable(
                name: "lock_type",
                newName: "LockTypes");

            migrationBuilder.RenameIndex(
                name: "IX_product_ShotgunActionTypeId",
                table: "Products",
                newName: "IX_Products_ShotgunActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_product_ScopeId",
                table: "Products",
                newName: "IX_Products_ScopeId");

            migrationBuilder.RenameIndex(
                name: "IX_product_RifleActionTypeId",
                table: "Products",
                newName: "IX_Products_RifleActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_product_RedDotSightId",
                table: "Products",
                newName: "IX_Products_RedDotSightId");

            migrationBuilder.RenameIndex(
                name: "IX_product_ProductId",
                table: "Products",
                newName: "IX_Products_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_product_MaterialId",
                table: "Products",
                newName: "IX_Products_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_product_ManufacturerId",
                table: "Products",
                newName: "IX_Products_ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_product_MagazineId",
                table: "Products",
                newName: "IX_Products_MagazineId");

            migrationBuilder.RenameIndex(
                name: "IX_product_HandleMaterialId",
                table: "Products",
                newName: "IX_Products_HandleMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_product_BladeMaterialId",
                table: "Products",
                newName: "IX_Products_BladeMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_product_Axe_HandleMaterialId",
                table: "Products",
                newName: "IX_Products_Axe_HandleMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_product_Axe_BladeMaterialId",
                table: "Products",
                newName: "IX_Products_Axe_BladeMaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShotgunActionTypes",
                table: "ShotgunActionTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SafetyTypes",
                table: "SafetyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RifleActionTypes",
                table: "RifleActionTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LockTypes",
                table: "LockTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_item_Products_ProductId",
                table: "item",
                column: "ProductId",
                principalTable: "Products",
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
        }
    }
}
