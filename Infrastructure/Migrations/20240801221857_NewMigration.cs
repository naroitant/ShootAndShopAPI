using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ActionType_ActionTypeId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActionType",
                table: "ActionType");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ActionType");

            migrationBuilder.RenameTable(
                name: "ActionType",
                newName: "ShotgunActionTypes");

            migrationBuilder.RenameColumn(
                name: "ActionTypeId",
                table: "Product",
                newName: "ShotgunActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ActionTypeId",
                table: "Product",
                newName: "IX_Product_ShotgunActionTypeId");

            migrationBuilder.AddColumn<Guid>(
                name: "RifleActionTypeId",
                table: "Product",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShotgunActionTypes",
                table: "ShotgunActionTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RifleActionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RifleActionTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_RifleActionTypeId",
                table: "Product",
                column: "RifleActionTypeId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_RifleActionTypes_RifleActionTypeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ShotgunActionTypes_ShotgunActionTypeId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "RifleActionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Product_RifleActionTypeId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShotgunActionTypes",
                table: "ShotgunActionTypes");

            migrationBuilder.DropColumn(
                name: "RifleActionTypeId",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "ShotgunActionTypes",
                newName: "ActionType");

            migrationBuilder.RenameColumn(
                name: "ShotgunActionTypeId",
                table: "Product",
                newName: "ActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ShotgunActionTypeId",
                table: "Product",
                newName: "IX_Product_ActionTypeId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ActionType",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActionType",
                table: "ActionType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ActionType_ActionTypeId",
                table: "Product",
                column: "ActionTypeId",
                principalTable: "ActionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
